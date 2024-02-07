

namespace GetGreeting
{
    public class timeProvider : ITimeProvider
    {
        public DateTime GetCurrentTime()
        {
            return DateTime.Now;
        }
    }

    public class FakeTimeProvider : ITimeProvider
    {
        private DateTime _fakeTime;
        public FakeTimeProvider(DateTime fakeTime)
        {

            _fakeTime = fakeTime;

        }
        public DateTime GetCurrentTime()
        {
            return _fakeTime;
        }
    }
}

