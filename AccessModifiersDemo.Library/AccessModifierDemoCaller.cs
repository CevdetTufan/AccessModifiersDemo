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
			//accessModifierDemo.InternalMethod(); // This will not work as InternalMethod is internal
			//accessModifierDemo.ProtectedInternalMethod(); // This will not work as ProtectedInternalMethod is protected internal
			//accessModifierDemo.PrivateProtectedMethod(); // This will not work as PrivateProtectedMethod is private protected
		}
	}
}
