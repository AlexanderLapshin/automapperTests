using System;
using System.Collections.Generic;
using System.Text;

namespace AutomapperTests
{
    public static class TestHelper
    {
        public static Object1[] CreateObjectsArray(int count)
        {
            Object1[] array = new Object1[count];

            for (int i = 0; i < count; i++)
            {
                array[i] = new Object1();
            }

            return array;
        }
    }
}
