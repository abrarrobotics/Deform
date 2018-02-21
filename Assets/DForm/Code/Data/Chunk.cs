﻿using UnityEngine;

namespace DForm
{
	[System.Serializable]
	public struct Chunk
	{
		public VertexData[] vertexData;
		public int Size { get { return vertexData.Length; } }

		public Chunk (VertexData[] vertexData)
		{
			this.vertexData = vertexData;
		}

		public Chunk (Vector3[] positions, Vector3[] normals)
		{
			vertexData = new VertexData[positions.Length];

			for (var i = 0; i < positions.Length; i++)
			{
				var position = positions[i];
				var normal = normals[i];
				vertexData[i] = new VertexData (position, position, normal);
			}
		}

		public Chunk (Vector3[] basePositions, Vector3[] positions, Vector3[] normals)
		{
			vertexData = new VertexData[positions.Length];

			for (var i = 0; i < positions.Length; i++)
			{
				var basePosition = basePositions[i];
				var position = positions[i];
				var normal = normals[i];
				vertexData[i] = new VertexData (basePosition, position, normal);
			}
		}

		public void ResetPositions ()
		{
			for (int i = 0; i < vertexData.Length; i++)
				vertexData[i].ResetPosition ();
		}
	}
}