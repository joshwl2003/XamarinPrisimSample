using System;
namespace PrismSampleApplication
{
    public class SampleServiceImplmentation:ISampleService
    {
        public SampleServiceImplmentation(IService2 service2)
        {
        }

        void ISampleService.DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
