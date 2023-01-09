﻿using AutoMapper;
using Microsoft.Extensions.Logging;
using SoundPlay.BLL.Exceptions;
using SoundPlay.BLL.Interfaces;
using SoundPlay.DAL.Repository.Interfaces;
using SoundPlay.DTO.Models;
using SoundPlay.DTO.ViewModels;

namespace SoundPlay.BLL.Services
{
    public class MaterialService:IGenericService<MaterialViewModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<MaterialService> _logger;

        public MaterialService(IUnitOfWork unitOfWork, IMapper mapper, ILogger<MaterialService> logger)
        {
            _unitOfWork=unitOfWork;
            _mapper=mapper;
            _logger=logger;
        }

        public async Task<MaterialViewModel> CreateViewModelAsync(MaterialViewModel viewModel)
        {
            var model = _mapper.Map<Material>(viewModel);

            try
            {
                _unitOfWork.Material.Add(model);
                await _unitOfWork.SaveChangesAsync();
                _logger.LogInformation("Create operation is successfull");
            }

            catch (Exception ex)
            {
                _logger.LogError($"Create operation is failed, {ex.Message}");
            }

            return viewModel;
        }

        public async Task<MaterialViewModel> DeleteViewModelAsync(MaterialViewModel viewModel)
        {
            var model = _mapper.Map<Material>(viewModel);

            try
            {
                _unitOfWork.Material.Remove(model);
                await _unitOfWork.SaveChangesAsync();
                _logger.LogInformation("Delete operation is successfull");
            }

            catch (Exception ex)
            {
                _logger.LogInformation($"Delete operation is failed, {ex.Message}");
            }

            return viewModel;
        }

        public async Task<MaterialViewModel> GetViewModelByIdAsync(int id)
        {
            var model = await _unitOfWork.Material.GetFirstOrDefaultAsync(b => b.Id==id);

            if (model==null)
            {
                _logger.LogError("Get_by_id operation is failed");
                throw new ObjectNotFoundException("No object found");
            }

            _logger.LogInformation("Get_by_id operation is successfull");
            var viewModel = _mapper.Map<MaterialViewModel>(model);
            return viewModel;
        }

        public async Task<IEnumerable<MaterialViewModel>> GetViewModelsAsync()
        {
            var models = await _unitOfWork.Material.GetAllAsync();

            if (models.Count()==0||models==null)
            {
                _logger.LogError("Get_All operation is failed");
                throw new ObjectNotFoundException("No object found");
            }

            _logger.LogInformation("Get_All operation is successfull");
            var viewModels = _mapper.Map<IEnumerable<MaterialViewModel>>(models);
            return viewModels;
        }

        public async Task<MaterialViewModel> UpdateViewModelAsync(MaterialViewModel viewModel)
        {
            var model = _mapper.Map<Material>(viewModel);

            try
            {
                _unitOfWork.Material.Update(model);
                await _unitOfWork.SaveChangesAsync();
                _logger.LogInformation("Update operation is successfull");
            }

            catch (Exception ex)
            {
                _logger.LogError($"Update operation is failed, {ex.Message}");
            }

            return viewModel;
        }
    }
}