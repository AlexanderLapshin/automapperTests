using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomapperTests
{
    public class AutomapperTester
    {
        public AutomapperTester()
        {

        }
        public void CalculateMappingTime(int objectsCount)
        {
            var mapper = InitializeMapper();
            var objectsArray = TestHelper.CreateObjectsArray(objectsCount);
            var objectsDtoArray = new Object1Dto[objectsCount];
            
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            for (int i = 0; i < objectsCount; i++)
            {
                mapper.Map(objectsArray[i], objectsDtoArray[i]);
            }

            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }

        private IMapper InitializeMapper()
        {
            var config = new MapperConfiguration(config => {
                config.CreateMap<Object1, Object1Dto>();
                });

            return config.CreateMapper();
        }
    }
}
