﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waher.Persistence.Attributes;

#if !LW
namespace Waher.Persistence.Files.Test.Classes
#else
using Waher.Persistence.Files;
namespace Waher.Persistence.FilesLW.Test.Classes
#endif
{
	public class ObjectIdByteArray
	{
		[ObjectId]
		public byte[] ObjectId;
		public int Value;

		public ObjectIdByteArray()
		{
		}
	}
}
