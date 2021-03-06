﻿namespace Eda.Integrations.Delivery
{
    /// <inheritdoc cref="IObject" />
    /// <summary>
    /// The data contract
    /// </summary>
    public interface IStreet : INamedObject, IGeography
    {
        /// <summary>
        /// Gets the city.
        /// </summary>
        ICity City { get; }
    }
}