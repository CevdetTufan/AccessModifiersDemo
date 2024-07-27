namespace AccessModifiersDemo.Library
{
	public class AccessModifierDemo
	{
		private void CallOwnMethods()
		{
			PrivateMethod();
			PublicMethod();
			ProtectedMethod();
			InternalMethod();
			ProtectedInternalMethod();
			PrivateProtectedMethod();
		}

		private void PrivateMethod()
		{
			// This method can only be accessed within this class
		}

		public void PublicMethod()
		{
			// This method can be accessed from anywhere
		}

		protected void ProtectedMethod()
		{
			// This method can be accessed from this class and any class that inherits from this class
		}

		internal void InternalMethod()
		{
			// This method can be accessed from the same assembly
		}

		protected internal void ProtectedInternalMethod()
		{
			// This method can be accessed from the same assembly and any class that inherits from this class
		}

		private protected void PrivateProtectedMethod()
		{
			// This method can be accessed from this class and any class that inherits from this class within the same assembly
		}
	}
}
