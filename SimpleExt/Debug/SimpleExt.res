        ��  ��                  �      �� ��     0 	        �4   V S _ V E R S I O N _ I N F O     ���               ?                        D   S t r i n g F i l e I n f o       0 4 0 9 0 4 B 0        C o m p a n y N a m e     J   F i l e D e s c r i p t i o n     S i m p l e E x t   M o d u l e     6   F i l e V e r s i o n     1 ,   0 ,   0 ,   1     4 
  I n t e r n a l N a m e   S i m p l e E x t   B   L e g a l C o p y r i g h t   C o p y r i g h t   2 0 0 0     D   O r i g i n a l F i l e n a m e   S i m p l e E x t . D L L   B   P r o d u c t N a m e     S i m p l e E x t   M o d u l e     :   P r o d u c t V e r s i o n   1 ,   0 ,   0 ,   1     (    O L E S e l f R e g i s t e r     D    V a r F i l e I n f o     $    T r a n s l a t i o n     	�	  0   R E G I S T R Y   ��e       0	        HKCR
{
    NoRemove CLSID
    {
        ForceRemove {489971B6-27A5-433C-8FEB-72E155231544} = s 'SimpleShlExt Class'
        {
            InprocServer32 = s '%MODULE%'
            {
                val ThreadingModel = s 'Apartment'
            }
        }
    }
    NoRemove txtfile
    {
        NoRemove ShellEx
        {
            NoRemove ContextMenuHandlers
            {
                ForceRemove SimpleShlExt = s '{489971B6-27A5-433C-8FEB-72E155231544}'
            }
        }
    }
}
   2       �� ��     0	                	 S i m p l e E x t                         