using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.SelectMany
{
    internal class SelectManyRefactoringChallange
    {
        //TODO implement this method
        public static Dictionary<string, double> SegmentsLengths_Refactored(
            IEnumerable<Point> starts, IEnumerable<Point> ends)
        {
            return starts.SelectMany(start => ends, (start, end) =>
            new
            {
                Start = start,
                End = end,
                Length = SegmentLength(start, end)
            }).ToDictionary(
                data => $"Start: ({data.Start})," + $" End: ({data.End})",
                data => data.Length
                );
        }

        //do not modify this method
        public static Dictionary<string, double> SegmentsLengths(
            IEnumerable<Point> starts, IEnumerable<Point> ends)
        {
            var result = new Dictionary<string, double>();
            foreach (var startPoint in starts)
            {
                foreach (var endPoint in ends)
                {
                    var length = SegmentLength(startPoint, endPoint);
                    var key = $"Start: ({startPoint}), End: ({endPoint})";
                    result[key] = length;
                }
            }
            return result;
        }

        public static double SegmentLength(Point start, Point end)
        {
            return Math.Sqrt((Math.Pow(start.X - end.X, 2) + Math.Pow(start.Y - end.Y, 2)));
        }
    }

    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }
    }
}
