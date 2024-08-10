﻿namespace LeetCode.Medium
{
    internal class RectangleArea
    {
        public static int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
        {
            int areaA = ((ax2 - ax1) * (ay2 - ay1)),
                areaB = ((bx2 - bx1) * (by2 - by1));

            if (bx1 >= ax2 || ax1 >= bx2 || by1 >= ay2 || ay1 >= by2)
                return areaA + areaB;

            int overlapArea = (Math.Min(ax2, bx2) - Math.Max(ax1, bx1)) * (Math.Min(ay2, by2) - Math.Max(ay1, by1));
            return areaA + areaB - overlapArea;
        }
    }
}
