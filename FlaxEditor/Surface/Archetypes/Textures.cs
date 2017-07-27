﻿////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2012-2017 Flax Engine. All rights reserved.
////////////////////////////////////////////////////////////////////////////////////

using System;
using FlaxEngine;

namespace FlaxEditor.Surface.Archetypes
{
    /// <summary>
    /// Contains archetypes for nodes from the Textures group.
    /// </summary>
    public static class Textures
    {
        /// <summary>
        /// The nodes for that group.
        /// </summary>
        public static NodeArchetype[] Nodes =
        {
            new NodeArchetype
            {
                TypeID = 1,
                Title = "Texture",
                Description = "Two dimensional texture object",
                Flags = NodeFlags.MaterialOnly,
                Size = new Vector2(140, 120),
                DefaultValues = new object[]
                {
                    Guid.Empty
                },
                Elements = new[]
                {
                    NodeElementArchetype.Factory.Input(0, "UVs", true, ConnectionType.Vector2, 0),
                    NodeElementArchetype.Factory.Output(0, "", ConnectionType.Object, 6),
                    NodeElementArchetype.Factory.Output(1, "Color", ConnectionType.Vector4, 1),
                    NodeElementArchetype.Factory.Output(2, "R", ConnectionType.Float, 2),
                    NodeElementArchetype.Factory.Output(3, "G", ConnectionType.Float, 3),
                    NodeElementArchetype.Factory.Output(4, "B", ConnectionType.Float, 4),
                    NodeElementArchetype.Factory.Output(5, "A", ConnectionType.Float, 5),
                    NodeElementArchetype.Factory.Asset(0, 20, 0, ContentDomain.Texture)
                }
            },
            new NodeArchetype
            {
                TypeID = 2,
                Title = "Texcoords",
                Description = "Texture coordinates",
                Flags = NodeFlags.MaterialOnly,
                Size = new Vector2(110, 30),
                Elements = new[]
                {
                    NodeElementArchetype.Factory.Output(0, "UVs", ConnectionType.Vector2, 0)
                }
            },
            new NodeArchetype
            {
                TypeID = 3,
                Title = "Cube Texture",
                Description = "Set of 6 textures arranged in a cube",
                Flags = NodeFlags.MaterialOnly,
                Size = new Vector2(140, 120),
                DefaultValues = new object[]
                {
                    Guid.Empty
                },
                Elements = new[]
                {
                    NodeElementArchetype.Factory.Input(0, "UVs", true, ConnectionType.Vector3, 0),
                    NodeElementArchetype.Factory.Output(0, "", ConnectionType.Object, 6),
                    NodeElementArchetype.Factory.Output(1, "Color", ConnectionType.Vector4, 1),
                    NodeElementArchetype.Factory.Output(2, "R", ConnectionType.Float, 2),
                    NodeElementArchetype.Factory.Output(3, "G", ConnectionType.Float, 3),
                    NodeElementArchetype.Factory.Output(4, "B", ConnectionType.Float, 4),
                    NodeElementArchetype.Factory.Output(5, "A", ConnectionType.Float, 5),
                    NodeElementArchetype.Factory.Asset(0, 20, 0, ContentDomain.CubeTexture)
                }
            },
            new NodeArchetype
            {
                TypeID = 4,
                Title = "Normal Map",
                Description = "Two dimensional texture object sampled as a normal map",
                Flags = NodeFlags.MaterialOnly,
                Size = new Vector2(140, 120),
                DefaultValues = new object[]
                {
                    Guid.Empty
                },
                Elements = new[]
                {
                    NodeElementArchetype.Factory.Input(0, "UVs", true, ConnectionType.Vector2, 0),
                    NodeElementArchetype.Factory.Output(0, "", ConnectionType.Object, 6),
                    NodeElementArchetype.Factory.Output(1, "Vector", ConnectionType.Vector3, 1),
                    NodeElementArchetype.Factory.Output(2, "X", ConnectionType.Float, 2),
                    NodeElementArchetype.Factory.Output(3, "Y", ConnectionType.Float, 3),
                    NodeElementArchetype.Factory.Output(4, "Z", ConnectionType.Float, 4),
                    NodeElementArchetype.Factory.Asset(0, 20, 0, ContentDomain.Texture)
                }
            },
            new NodeArchetype
            {
                TypeID = 5,
                Title = "Parallax Occlusion Mapping",
                Description = "Parallax occlusion mapping",
                Flags = NodeFlags.MaterialOnly,
                Size = new Vector2(260, 120),
                DefaultValues = new object[]
                {
                    0.05f,
                    8.0f,
                    20.0f,
                    0
                },
                Elements = new[]
                {
                    NodeElementArchetype.Factory.Input(0, "UVs", true, ConnectionType.Vector2, 0),
                    NodeElementArchetype.Factory.Input(1, "Scale", true, ConnectionType.Float, 1),
                    NodeElementArchetype.Factory.Input(2, "Min Steps", true, ConnectionType.Float, 2),
                    NodeElementArchetype.Factory.Input(3, "Max Steps", true, ConnectionType.Float, 3),
                    NodeElementArchetype.Factory.Input(4, "Heightmap Texture", true, ConnectionType.Object, 4),
                    NodeElementArchetype.Factory.Output(0, "Parallax UVs", ConnectionType.Vector2, 5),
                    NodeElementArchetype.Factory.Text(Surface.Constants.BoxSize + 4, 5 * Surface.Constants.LayoutOffsetY, "Channel"),
                    NodeElementArchetype.Factory.CmoboBox(70, 5 * Surface.Constants.LayoutOffsetY, 50, 3, new[]
                    {
                        "R",
                        "G",
                        "B",
                        "A",
                    })
                }
            },
        };
    }
}