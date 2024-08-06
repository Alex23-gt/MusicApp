using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp_Redesign
{
    public class TrackRating
    {
        [LoadColumn(0)]
        public float Label;
        [LoadColumn(1)]
        public float userId;
        [LoadColumn(2)]
        public float trackId;
    }

    internal class Rating
    {
        public (IDataView training, IDataView test) LoadData(MLContext mlContext)
        {
            var trainingDataPath = Path.Combine(Environment.CurrentDirectory, "Data", "ratings.csv");
            var testDataPath = Path.Combine(Environment.CurrentDirectory, "Data", "ratingsTest.csv");

            IDataView trainingDataView = mlContext.Data.LoadFromTextFile<TrackRating>(trainingDataPath, hasHeader: true, separatorChar: ';');
            IDataView testDataView = mlContext.Data.LoadFromTextFile<TrackRating>(testDataPath, hasHeader: true, separatorChar: ';');

            return (trainingDataView, testDataView);
        }

        public ITransformer BuildAndTrainModel(MLContext mlContext, IDataView trainingDataView)
        {
            IEstimator<ITransformer> estimator = mlContext.Transforms.Conversion.MapValueToKey(outputColumnName: "userIdEncoded", inputColumnName: "userId")
    .Append(mlContext.Transforms.Conversion.MapValueToKey(outputColumnName: "trackIdEncoded", inputColumnName: "trackId"));
            var options = new MatrixFactorizationTrainer.Options
            {
                MatrixColumnIndexColumnName = "userIdEncoded",
                MatrixRowIndexColumnName = "trackIdEncoded",
                LabelColumnName = "Label",
                NumberOfIterations = 20,
                ApproximationRank = 100
            };

            var trainerEstimator = estimator.Append(mlContext.Recommendation().Trainers.MatrixFactorization(options));

            //Console.WriteLine("=============== Training the model ===============");
            ITransformer model = trainerEstimator.Fit(trainingDataView);

            return model;
        }

        public void EvaluateModel(MLContext mlContext, IDataView testDataView, ITransformer model)
        {
            //Console.WriteLine("=============== Evaluating the model ===============");
            var prediction = model.Transform(testDataView);
            var metrics = mlContext.Regression.Evaluate(prediction, labelColumnName: "Label", scoreColumnName: "Score");
            //Console.WriteLine("Root Mean Squared Error : " + metrics.RootMeanSquaredError.ToString());
            //Console.WriteLine("RSquared: " + metrics.RSquared.ToString());
        }
        public string UseModelForSinglePrediction(MLContext mlContext, ITransformer model, float selectedUser, float selectedTrack)
        {
            string result;
            //Console.WriteLine("=============== Making a prediction ===============");
            var predictionEngine = mlContext.Model.CreatePredictionEngine<TrackRating, TrackRatingPrediction>(model);
            var testInput = new TrackRating { userId = selectedUser, trackId = selectedTrack };

            var movieRatingPrediction = predictionEngine.Predict(testInput);
            if (Math.Round(movieRatingPrediction.Score, 1) >= 4)
            {
                result = "Трек " + testInput.trackId + " рекомендован " + testInput.userId + "\n";
                result += "Рейтинг: " + movieRatingPrediction.Score;
            }
            else if(Math.Round(movieRatingPrediction.Score, 1) >= 2.5 && Math.Round(movieRatingPrediction.Score, 1) <= 4)
            {
                result = "Трек " + testInput.trackId + " частично рекомендован " + testInput.userId + "\n";
                result += "Рейтинг: " + movieRatingPrediction.Score;

            }
            else
            {
                result = "Трек " + testInput.trackId + " не рекомендован " + testInput.userId + "\n";
                result += "Рейтинг: " + movieRatingPrediction.Score;
            }
            return result;
        }
    }
}
