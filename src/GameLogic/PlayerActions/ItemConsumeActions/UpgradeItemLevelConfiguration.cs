﻿// -----------------------------------------------------------------------
// <copyright file="UpgradeItemLevelConfiguration.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace MUnique.OpenMU.GameLogic.PlayerActions.ItemConsumeActions;

using System.ComponentModel.DataAnnotations;
using MUnique.OpenMU.DataModel.Configuration.Items;

/// <summary>
/// Configuration for a <see cref="UpgradeItemLevelJewelConsumeHandlerPlugIn{TConfig}"/>.
/// </summary>
public class UpgradeItemLevelConfiguration
{
    private byte _levelAmount = 1;

    /// <summary>
    /// Gets or sets the success rate percentage.
    /// </summary>
    public byte SuccessRatePercentage { get; set; }

    /// <summary>
    /// Gets or sets the success rate bonus with luck percentage.
    /// </summary>
    [Display(Name = "Success Rate Luck Bonus %", Description = "The additional success rate, when the item has luck option.")]
    public byte SuccessRateBonusWithLuckPercentage { get; set; }

    /// <summary>
    /// Gets or sets the minimum item level which the item has to have before applying the jewel.
    /// </summary>
    [Display(Name = "Item Minimum Level", Description = "The minimum item level which the item has to have before applying the jewel.")]
    public byte MinimumLevel { get; set; }

    /// <summary>
    /// Gets or sets the maximum item level which the item has to have before applying the jewel.
    /// </summary>
    [Display(Name = "Item Maximum Level", Description = "The maximum item level which the item has to have before applying the jewel.")]
    public byte MaximumLevel { get; set; }

    /// <summary>
    /// Gets or sets the amount of levels which the item will be upgraded by.
    /// </summary>
    [Display(Name = "Add Levels Amount", Description = "How many times to add a level to the item (will become maximum allowed level).")]
    public byte LevelAmount
    {
        get => this._levelAmount;
        set => this._levelAmount = value;
    }

    /// <summary>
    /// Gets the items which are allowed to be upgraded. If empty, all items are allowed except those in <see cref="DisallowedItems"/>.
    /// </summary>
    public ICollection<ItemDefinition> AllowedItems { get; set; } = new List<ItemDefinition>();

    /// <summary>
    /// Gets the items which are not allowed to be upgraded.
    /// </summary>
    public ICollection<ItemDefinition> DisallowedItems { get; set; } = new List<ItemDefinition>();

    /// <summary>
    /// Gets the drop item groups which are allowed to be upgraded. If empty, all drop item groups are allowed except those in <see cref="DisallowedDropItemGroups"/>.
    /// </summary>
    public ICollection<DropItemGroup> AllowedDropItemGroups { get; set; } = new List<DropItemGroup>();

    /// <summary>
    /// Gets the drop item groups which are not allowed to be upgraded.
    /// </summary>
    public ICollection<DropItemGroup> DisallowedDropItemGroups { get; set; } = new List<DropItemGroup>();

    /// <summary>
    /// Gets or sets the item level after which the item will drop to level 0 when it fails.
    /// </summary>
    [Display(Name = "Fail To 0 min. Level", Description = "The item level after which the item will drop to level 0 when it fails.")]
    public byte ResetToLevel0WhenFailMinLevel { get; set; }
}