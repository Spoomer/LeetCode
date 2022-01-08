global using Xunit;
using src.Problems;

namespace LeetCode.Test
{
    public class RotateImageTests
    {
        [Fact]
        public void ShouldNotRotate_Length1()
        {
            int[][] image = new int[1][];
            int[][] image2 = new int[1][];
            image[0] = new int[] { 1 };
            image.CopyTo(image2, 0);
            RotateImage.Rotate90(image);
            Assert.Equal(image2, image);
        }
        [Fact]
        public void ShouldRotate_Length2()
        {
            int[][] image = new int[2][];
            int[][] image2 = new int[2][];
            image[0] = new int[] { 1, 2 };
            image[1] = new int[] { 3, 4 };
            image2[0] = new int[] { 3, 1 };
            image2[1] = new int[] { 4, 2 };
            RotateImage.Rotate90(image);
            Assert.Equal(image2, image);
        }
        [Fact]
        public void ShouldRotate_Length3()
        {
            int[][] image = new int[3][];
            int[][] image2 = new int[3][];
            image[0] = new int[] { 1, 2, 3 };
            image[1] = new int[] { 4, 5, 6 };
            image[2] = new int[] { 7, 8, 9 };
            image2[0] = new int[] { 7, 4, 1 };
            image2[1] = new int[] { 8, 5, 2 };
            image2[2] = new int[] { 9, 6, 3 };
            RotateImage.Rotate90(image);
            Assert.Equal(image2, image);
        }
        [Fact]
        public void ShouldRotate_Length4()
        {
            int[][] image = new int[4][];
            int[][] image2 = new int[4][];
            image[0] = new int[] { 1, 2, 3, 4 };
            image[1] = new int[] { 5, 6, 7, 8 };
            image[2] = new int[] { 9, 10, 11, 12 };
            image[3] = new int[] { 13, 14, 15, 16 };
            image2[0] = new int[] { 13, 9, 5, 1 };
            image2[1] = new int[] { 14, 10, 6, 2 };
            image2[2] = new int[] { 15, 11, 7, 3 };
            image2[3] = new int[] { 16, 12, 8, 4 };
            RotateImage.Rotate90(image);
            Assert.Equal(image2, image);
        }
    }
}