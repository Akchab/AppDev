

using AppDev.Application.Common.Interface;

namespace AppDev.Infrastructure.Services
{
    public class DateTimeService: IDateTime

    {
        public DateTime now => DateTime.UtcNow;

        public DateTime Now { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
