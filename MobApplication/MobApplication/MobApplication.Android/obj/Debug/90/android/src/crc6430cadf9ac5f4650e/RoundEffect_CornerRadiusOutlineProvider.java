package crc6430cadf9ac5f4650e;


public class RoundEffect_CornerRadiusOutlineProvider
	extends android.view.ViewOutlineProvider
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getOutline:(Landroid/view/View;Landroid/graphics/Outline;)V:GetGetOutline_Landroid_view_View_Landroid_graphics_Outline_Handler\n" +
			"";
		mono.android.Runtime.register ("MobApplication.Droid.RoundEffect+CornerRadiusOutlineProvider, MobApplication.Android", RoundEffect_CornerRadiusOutlineProvider.class, __md_methods);
	}


	public RoundEffect_CornerRadiusOutlineProvider ()
	{
		super ();
		if (getClass () == RoundEffect_CornerRadiusOutlineProvider.class)
			mono.android.TypeManager.Activate ("MobApplication.Droid.RoundEffect+CornerRadiusOutlineProvider, MobApplication.Android", "", this, new java.lang.Object[] {  });
	}


	public void getOutline (android.view.View p0, android.graphics.Outline p1)
	{
		n_getOutline (p0, p1);
	}

	private native void n_getOutline (android.view.View p0, android.graphics.Outline p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
