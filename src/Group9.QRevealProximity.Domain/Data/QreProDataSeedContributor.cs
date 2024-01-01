using Group9.QRevealProximity.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Group9.QRevealProximity.Data
{
    public class QreProDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Location, Guid> _locationRepository;

        public QreProDataSeedContributor(IRepository<Location, Guid> locationRepository)
        {
            this._locationRepository = locationRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            var h6_location = new Location
            {
                Name = "h6-hcmut",
                Address = "VRJ4+65C, Đông Hoà, Dĩ An, Bình Dương",
                Description = "Là tòa nhà rất đẹp",
                ImageFileName = "h6_hcmut.jpg",
                Longitude = 10.87944,
                Latitude = 106.8063
            };

            var h1_location = new Location
            {
                Name = "h1-hcmut",
                Address = "VRJ4+65C, Đông Hoà, Dĩ An, Bình Dương",
                Description = "Là tòa nhà rất đẹp",
                ImageFileName = "h1_hcmut.jpg",
                Longitude = 10.880121,
                Latitude = 106.804700
            };

            var h2_location = new Location
            {
                Name = "h2-hcmut",
                Address = "VRJ4+65C, Đông Hoà, Dĩ An, Bình Dương",
                Description = "Là tòa nhà rất đẹp",
                ImageFileName = "h2_hcmut.jpg",
                Longitude = 10.880561,
                Latitude = 106.805094
            };

            var h3_location = new Location
            {
                Name = "h3-hcmut",
                Address = "VRJ4+65C, Đông Hoà, Dĩ An, Bình Dương",
                Description = "Là tòa nhà rất đẹp",
                ImageFileName = "h3_hcmut.jpg",
                Longitude = 10.881086,
                Latitude = 106.805349
            };

            await _locationRepository
                .InsertManyAsync(new[] { h6_location, h1_location, h2_location, h3_location });
        }
    }
}
