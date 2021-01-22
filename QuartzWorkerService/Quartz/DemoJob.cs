using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzWorkerService.Quartz
{
    public class DemoJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"{DateTime.Now} - DemoJob运行了。。。");
            });
        }
    }
}
