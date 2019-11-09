using Pomelo.AspNetCore.TimedJob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimedJobDemo.TimedJobs
{
    public class CommonTimedJobs:Job
    {
        // Begin 起始时间；Interval执行时间间隔，单位是毫秒，建议使用以下格式，此处为3小时；
        //SkipWhileExecuting是否等待上一个执行完成，true为等待；
        [Invoke(Begin = "2019-11-09 22:10", Interval = 1000 * 3600 * 24, SkipWhileExecuting = true)]
        public void Run()
        {
            //Job要执行的逻辑代码

        }
    }
}
