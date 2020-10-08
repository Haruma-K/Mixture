﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GraphProcessor;
using System.Linq;
using UnityEngine.Rendering;

namespace Mixture
{
	[System.Serializable, NodeMenuItem("Math/Vector Mul")]
	public class VectorMulNode : MixtureNode
	{
		// TODO: Vectormulti VectorMul port
		public override bool hasSettings => false;

		[Input("A")]
		public Vector4	a;
		
		[Input("B")]
		public Vector4	b;
		
		[Output("Out")]
		public Vector4	o;

		public override string name => "Mul";
		public override float nodeWidth => MixtureUtils.operatorNodeWidth;

		protected override bool ProcessNode(CommandBuffer cmd)
		{
			o = Vector4.Scale(a, b);
			return true;
		}
	}
}