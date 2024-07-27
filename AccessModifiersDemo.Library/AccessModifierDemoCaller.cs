namespace AccessModifiersDemo.Library
{
	public class AccessModifierDemoCaller
	{
		private void CallMethods()
		{
			AccessModifierDemo accessModifierDemo = new AccessModifierDemo();
			
			//accessModifierDemo.PrivateMethod();  // This will not work as PrivateMethod is private
			accessModifierDemo.PublicMethod();
			//accessModifierDemo.ProtectedMethod(); // This will not work as ProtectedMethod is protected
			accessModifierDemo.InternalMethod();
			accessModifierDemo.ProtectedInternalMethod();
			//accessModifierDemo.PrivateProtectedMethod(); // This will not work as PrivateProtectedMethod is private protected
		}
	}
}
