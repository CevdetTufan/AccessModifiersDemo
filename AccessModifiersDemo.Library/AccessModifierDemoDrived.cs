namespace AccessModifiersDemo.Library
{
	public class AccessModifierDemoDrived : AccessModifierDemo
	{
		public void CallDrivedClassMethods()
		{
			//this.PrivateMethod(); // This will not work as PrivateMethod is private
			this.PublicMethod();
			this.ProtectedMethod();
			//this.InternalMethod(); // This will not work as InternalMethod is internal
			this.ProtectedInternalMethod();
			//this.PrivateProtectedMethod(); // This will not work as PrivateProtectedMethod is private protected
		}
	}
}
