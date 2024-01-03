using AutoMapper;
using Group9.QRevealProximity.Locations;

namespace Group9.QRevealProximity;

public class QRevealProximityApplicationAutoMapperProfile : Profile
{
    public QRevealProximityApplicationAutoMapperProfile()
    {
        CreateMap<Location, LocationDto>();
    }
}
