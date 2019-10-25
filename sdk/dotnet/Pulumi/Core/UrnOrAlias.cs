﻿// Copyright 2016-2019, Pulumi Corporation

using System;

namespace Pulumi
{
    public readonly struct UrnOrAlias
    {
        public string? Urn { get; }
        public Alias? Alias { get; }

        private UrnOrAlias(string? urn, Alias? alias)
        {
            if (urn == null && alias == null)
            {
                throw new ArgumentException("One of urn or alias must be non-null");
            }

            Urn = urn;
            Alias = alias;
        }

        public static implicit operator UrnOrAlias(string urn)
            => new UrnOrAlias(urn, alias: null);

        public static implicit operator UrnOrAlias(Alias alias)
            => new UrnOrAlias(urn: null, alias);
    }
}