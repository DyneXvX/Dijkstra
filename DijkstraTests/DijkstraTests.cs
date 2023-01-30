using DijkstraAlgorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DijkstraAlgorithm.Tests
{
    [TestClass()]
    public class DijkstraTests
    {
        //[TestMethod()]
        //public void DijkstraAlgoTest()
        //{
        //    //arrange
        //    int[,] graph =  {
        //                      { 0, 6, 0, 0, 0, 0, 0, 9, 0 },
        //                      { 6, 0, 9, 0, 0, 0, 0, 11, 0 },
        //                      { 0, 9, 0, 5, 0, 6, 0, 0, 2 },
        //                      { 0, 0, 5, 0, 9, 16, 0, 0, 0 },
        //                      { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
        //                      { 0, 0, 6, 0, 10, 0, 2, 0, 0 },
        //                      { 0, 0, 0, 16, 0, 2, 0, 1, 6 },
        //                      { 9, 11, 0, 0, 0, 0, 1, 0, 5 },
        //                      { 0, 0, 2, 0, 0, 0, 6, 5, 0 }
        //                        };

        //    int source = 0;
        //    int verticesCount = 9;
        //    //act

        //    Dijkstra.DijkstraAlgo(graph, source, verticesCount);

        //    //assert

        //    Assert.AreEqual(9, verticesCount);
        //}

        [TestMethod()]
        public void DijkstraAlgo()
        {
            //arrange

            int[,] graph = new int[,]  {
                              { 0, 6, 0, 0, 0, 0, 0, 9, 0 },
                              { 6, 0, 9, 0, 0, 0, 0, 11, 0 },
                              { 0, 9, 0, 5, 0, 6, 0, 0, 2 },
                              { 0, 0, 5, 0, 9, 16, 0, 0, 0 },
                              { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                              { 0, 0, 6, 0, 10, 0, 2, 0, 0 },
                              { 0, 0, 0, 16, 0, 2, 0, 1, 6 },
                              { 9, 11, 0, 0, 0, 0, 1, 0, 5 },
                              { 0, 0, 2, 0, 0, 0, 6, 5, 0 }
                                };

            int source = 0;
            int verticesCount = 9;

            //act
            Dijkstra.DijkstraAlgo(graph, source, verticesCount);
        }
    }
}