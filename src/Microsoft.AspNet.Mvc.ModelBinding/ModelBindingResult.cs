// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNet.Mvc.ModelBinding
{
    /// <summary>
    /// Contains the result of model binding.
    /// </summary>
    public class ModelBindingResult
    {
        /// <summary>
        /// Creates a new <see cref="ModelBindingResult"/>.
        /// </summary>
        /// <param name="model">The model which was created by the <see cref="IModelBinder"/>.</param>
        /// <param name="key">The key using which was used to attempt binding the model.</param>
        /// <param name="isModelSet">A value that represents if the model has been set by the
        /// <see cref="IModelBinder"/>.</param>
        public ModelBindingResult(object model, string key, bool isModelSet)
        {
            Model = model;
            Key = key;
            IsModelSet = isModelSet;
        }

        /// <summary>
        /// Creates a new <see cref="ModelBindingResult"/>.
        /// </summary>
        /// <param name="model">The model which was created by the <see cref="IModelBinder"/>.</param>
        /// <param name="key">The key using which was used to attempt binding the model.</param>
        /// <param name="isModelSet">
        /// A value that represents if the model has been set by the <see cref="IModelBinder"/>.
        /// </param>
        /// <param name="isEmptyModel">
        /// If <paramref name="isModelSet"/> is <c>true</c> and this value is <c>true</c>, the <paramref name="model"/>
        /// was set but contains only default values. If <paramref name="isModelSet"/> is <c>true</c> and this value is
        /// <c>false</c>, the model contains bound properties. Ignored if <paramref name="isModelSet"/> is
        /// <c>false</c>.
        /// </param>
        public ModelBindingResult(object model, string key, bool isModelSet, bool isEmptyModel)
            : this(model, key, isModelSet)
        {
            IsEmptyModel = isEmptyModel;
        }

        /// <summary>
        /// Gets the model associated with this context.
        /// </summary>
        public object Model { get; }

        /// <summary>
        /// <para>
        /// Gets the model name which was used to bind the model.
        /// </para>
        /// <para>
        /// This property can be used during validation to add model state for a bound model.
        /// </para>
        /// </summary>
        public string Key { get; }

        /// <summary>
        /// <para>
        /// Gets a value indicating whether or not the <see cref="Model"/> value has been set.
        /// </para>
        /// <para>
        /// This property can be used to distinguish between a model binder which does not find a value and
        /// the case where a model binder sets the <c>null</c> value.
        /// </para>
        /// </summary>
        public bool IsModelSet { get; }

        /// <summary>
        /// <para>
        /// Gets a value indicating whether the <see cref="Model"/> contains only default values.
        /// </para>
        /// <para>
        /// Used to distinguish between a created <see cref="Model"/> and a <see cref="Model"/> that also has bound
        /// properties.
        /// </para>
        /// </summary>
        public bool IsEmptyModel { get; }
    }
}
