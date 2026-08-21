using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MG.GIF
{
	public class Decoder : IDisposable
	{
		[Flags]
		private enum ImageFlag
		{
			Interlaced = 0x40,
			ColourTable = 0x80,
			TableSizeMask = 7,
			BitDepthMask = 0x70
		}

		private enum Block
		{
			Image = 44,
			Extension = 33,
			End = 59
		}

		private enum Extension
		{
			GraphicControl = 249,
			Comments = 254,
			PlainText = 1,
			ApplicationData = 255
		}

		private enum Disposal
		{
			None = 0,
			DoNotDispose = 4,
			RestoreBackground = 8,
			ReturnToPrevious = 12
		}

		[Flags]
		private enum ControlFlags
		{
			HasTransparency = 1,
			DisposalMask = 0xC
		}

		public string Version;

		public ushort Width;

		public ushort Height;

		public Color32 BackgroundColour;

		private const uint NoCode = 65535u;

		private const ushort NoTransparency = ushort.MaxValue;

		private byte[] Input;

		private int D;

		private Color32[] GlobalColourTable;

		private Color32[] LocalColourTable;

		private Color32[] ActiveColourTable;

		private ushort TransparentIndex;

		private Image Image;

		private ushort ImageLeft;

		private ushort ImageTop;

		private ushort ImageWidth;

		private ushort ImageHeight;

		private Color32[] Output;

		private Color32[] PreviousImage;

		private readonly int[] Pow2;

		private int[] Indices;

		private ushort[] Codes;

		private uint[] CurBlock;

		public Decoder(byte[] data)
		{
		}

		public Decoder Load(byte[] data)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private byte ReadByte()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ushort ReadUInt16()
		{
			return 0;
		}

		private void ReadHeader()
		{
		}

		public Image NextImage()
		{
			return null;
		}

		private Color32[] ReadColourTable(Color32[] colourTable, ImageFlag flags)
		{
			return null;
		}

		private void SkipBlocks()
		{
		}

		private void ReadControlBlock()
		{
		}

		private Image ReadImageBlock()
		{
			return null;
		}

		private void Deinterlace()
		{
		}

		public Decoder()
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		private void DecompressLZW()
		{
		}

		public static string Ident()
		{
			return null;
		}
	}
}
