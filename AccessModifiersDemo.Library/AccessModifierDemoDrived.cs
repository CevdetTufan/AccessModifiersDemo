namespace AccessModifiersDemo.Library
{
	public class AccessModifierDemoDrived : AccessModifierDemo
	{
		public void CallDrivedClassMethods()
		{
			//this.PrivateMethod(); // This will not work as PrivateMethod is private
			this.PublicMethod();
			this.ProtectedMethod();
			this.InternalMethod();
			this.ProtectedInternalMethod();
			this.PrivateProtectedMethod(); 
		}
	}
}
