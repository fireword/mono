//
// System.Collections.Generic.KeyValuePair
//
// Authors:
//	Ben Maurer (bmaurer@users.sourceforge.net)
//
// (C) 2003 Ben Maurer
//

#if NET_2_0
using System;
using System.Runtime.InteropServices;

namespace System.Collections.Generic {
	[CLSCompliant(false)]
	public struct KeyValuePair<K,V> {
		K key;
		V val;
		
		public KeyValuePair (K key, V val)
		{
			this.key = key;
			this.val = val;
		}
		
		public K Key {
			get { return key; }
			set {
				if (value == null)
					throw new ArgumentNullException ();
				key = value;
			}
		}
		
		public V Value {
			get { return val; }
			set { val = value; }
		}
	}
}
#endif
