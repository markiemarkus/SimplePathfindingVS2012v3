﻿using System;
using System.Drawing;

namespace SimplePathfinding.Helpers
{
    public class HeuristicHelper
    {
        /// <summary>
        /// Calculates fast (without square root) euclidean distance between two points.
        /// </summary>
        /// <param name="start">The start point.</param>
        /// <param name="end">The end point.</param>
        /// <returns></returns>
        public static int FastEuclideanDistance(Point start, Point end)
        {
            return (end.X - start.X) * (end.X - start.X) + (end.Y - start.Y) * (end.Y - start.Y);
        }
    }
}
