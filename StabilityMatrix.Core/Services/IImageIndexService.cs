﻿using DynamicData.Binding;
using StabilityMatrix.Core.Models;
using StabilityMatrix.Core.Models.Database;
using StabilityMatrix.Core.Models.FileInterfaces;

namespace StabilityMatrix.Core.Services;

public interface IImageIndexService
{
    IndexCollection<LocalImageFile, string> InferenceImages { get; }

    /// <summary>
    /// Refresh index for all collections
    /// </summary>
    Task RefreshIndexForAllCollections();

    Task RefreshIndex(IndexCollection<LocalImageFile, string> indexCollection);

    /// <summary>
    /// Refreshes the index of local images in the background
    /// </summary>
    void BackgroundRefreshIndex();
}
