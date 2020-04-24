// <copyright company="Roche Diagnostics AG">
// Copyright (c) Roche Diagnostics AG. All rights reserved.
// </copyright>

using System;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoCRUD
{
    public class MModel
    {

        [BsonId]
        public Guid Id { get; set; }
    }
}