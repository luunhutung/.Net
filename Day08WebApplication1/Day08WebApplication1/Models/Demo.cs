using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Day08WebApplication1.Models
{
    public class Demo
    {
        #region Không Async
        public string Test01()
        {
            Thread.Sleep(2000);
            return $"Lucky number: {new Random().Next()}";
        }

        public int Test02()
        {
            Thread.Sleep(5000);
            return new Random().Next(100, 1000);
        }

        public void Test03()
        {
            Thread.Sleep(3000);
        }
        #endregion

        #region Có Async
        public async Task<string> Test01Async()
        {
            await Task.Delay(2000);
            return $"Lucky number: {new Random().Next()}";
        }

        public async Task<int> Test02Async()
        {
            await Task.Delay(5000);
            return new Random().Next(100, 1000);
        }

        public async Task Test03Async()
        {
            await Task.Delay(3000);
        }
        #endregion

    }
}
