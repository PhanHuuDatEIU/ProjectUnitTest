using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectUnitTest.Data
{
    public class TriangleService
    {
        private static readonly List<Triangle> boundaryTriangles = new List<Triangle>()
        {
            new Triangle(105,105,5),
            new Triangle(105,105,6),
            new Triangle(105,105,105),
            new Triangle(105,105,204),
            new Triangle(105,105,205),

            new Triangle(105,5,105),
            new Triangle(105,6,105),
            new Triangle(105,204,105),
            new Triangle(105,205,105),

            new Triangle(5,105,105),
            new Triangle(6,105,105),
            new Triangle(204,105,105),
            new Triangle(205,105,105),
        };
        private static readonly List<Triangle> robustnessBoundaryTriangles = new List<Triangle>()
        {
            new Triangle(105,105,4),
            new Triangle(105,105,5),
            new Triangle(105,105,6),
            new Triangle(105,105,105),
            new Triangle(105,105,204),
            new Triangle(105,105,205),
            new Triangle(105,105,206),

            new Triangle(105,4,105),
            new Triangle(105,5,105),
            new Triangle(105,6,105),
            new Triangle(105,204,105),
            new Triangle(105,205,105),
            new Triangle(105,206,105),

            new Triangle(4,105,105),
            new Triangle(5,105,105),
            new Triangle(6,105,105),
            new Triangle(204,105,105),
            new Triangle(205,105,105),
            new Triangle(206,105,105),
        };
        public Task<List<Triangle>> GetBoundaryTriangleListAsync()
        {
            return Task.FromResult(boundaryTriangles);
        }

        public Task<List<Triangle>> GetRobustnessBoundaryTriangleListAsync()
        {
            return Task.FromResult(robustnessBoundaryTriangles);
        }
    }
}
