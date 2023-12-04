﻿using AdvertisementPortal.Core;
using AdvertisementPortal.Core.Models.Domains;
using AdvertisementPortal.Core.Services;

namespace AdvertisementPortal.Persistence.Services
{
	public class AdvertisementService : IAdvertisementService
	{
		private readonly IUnitOfWork _unitOfWork;

		public AdvertisementService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public IEnumerable<Advertisement> GetAdvertisements()
			=> _unitOfWork.Advertisement.GetAdvertisements();

		public Advertisement GetAdvertisement(int advertisementId)
			=> _unitOfWork.Advertisement.GetAdvertisement(advertisementId);

		public void Delete(int id, string userId)
		{
			_unitOfWork.Advertisement.Delete(id, userId);
			_unitOfWork.Complete();
		}
	}
}
