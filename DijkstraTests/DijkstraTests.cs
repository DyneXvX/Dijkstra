using DijkstraAlgorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DijkstraAlgorithm.Tests
{
    [TestClass()]
    public class DijkstraTests
    {
        [TestMethod()]
        public void DijkstraAlgo()
        {
            //arrange

            int[,] graph = {
                              { 0, 6, 0, 0, 0, 0, 0, 9, },
                              { 6, 0, 9, 0, 0, 0, 0, 11, },
                              { 0, 9, 0, 5, 0, 6, 0, 0, },
                              { 0, 0, 5, 0, 9, 16, 0, 0, },
                              { 0, 0, 0, 9, 0, 10, 0, 0, },
                              { 0, 0, 6, 0, 10, 0, 2, 0, },
                              { 0, 0, 0, 16, 0, 2, 0, 1, },
                              { 9, 11, 0, 0, 0, 0, 1, 0, },
                              { 0, 0, 2, 0, 0, 0, 6, 5, }
                                };

            int source = 0;
            int verticesCount = 8;

            //act

            //assert
            Assert.AreEqual(8, verticesCount);
            Dijkstra.DijkstraAlgo(graph, source, verticesCount);
        }
    }
}