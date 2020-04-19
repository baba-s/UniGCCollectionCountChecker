﻿using System;

namespace UniGCCollectionCountChecker
{
	/// <summary>
	/// GC が何回発生したか計測するクラス
	/// </summary>
	public sealed class GCCollectionCountChecker
	{
		//==============================================================================
		// 変数
		//==============================================================================
		private int m_startCount;

		//==============================================================================
		// プロパティ
		//==============================================================================
		public int Count { get; private set; }

		//==============================================================================
		// 関数
		//==============================================================================
		/// <summary>
		/// 計測を開始します
		/// </summary>
		public void Start()
		{
			m_startCount = GC.CollectionCount( 0 );
			Count        = 0;
		}

		/// <summary>
		/// 計測を終了します
		/// </summary>
		public void Stop()
		{
			Count = GC.CollectionCount( 0 ) - m_startCount;
		}
	}
}