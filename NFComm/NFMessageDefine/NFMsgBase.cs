//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: NFMsgBase.proto
// Note: requires additional types generated from: NFDefine.proto
namespace NFMsg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PropertyInt")]
  public partial class PropertyInt : global::ProtoBuf.IExtensible
  {
    public PropertyInt() {}
    
    private byte[] _property_name;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"property_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] property_name
    {
      get { return _property_name; }
      set { _property_name = value; }
    }
    private int _data;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PropertyFloat")]
  public partial class PropertyFloat : global::ProtoBuf.IExtensible
  {
    public PropertyFloat() {}
    
    private byte[] _property_name;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"property_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] property_name
    {
      get { return _property_name; }
      set { _property_name = value; }
    }
    private float _data;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PropertyString")]
  public partial class PropertyString : global::ProtoBuf.IExtensible
  {
    public PropertyString() {}
    
    private byte[] _property_name;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"property_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] property_name
    {
      get { return _property_name; }
      set { _property_name = value; }
    }
    private byte[] _data;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PropertyObject")]
  public partial class PropertyObject : global::ProtoBuf.IExtensible
  {
    public PropertyObject() {}
    
    private byte[] _property_name;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"property_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] property_name
    {
      get { return _property_name; }
      set { _property_name = value; }
    }
    private long _data;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RecordInt")]
  public partial class RecordInt : global::ProtoBuf.IExtensible
  {
    public RecordInt() {}
    
    private int _row;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"row", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int row
    {
      get { return _row; }
      set { _row = value; }
    }
    private int _col;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"col", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int col
    {
      get { return _col; }
      set { _col = value; }
    }
    private int _data;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RecordFloat")]
  public partial class RecordFloat : global::ProtoBuf.IExtensible
  {
    public RecordFloat() {}
    
    private int _row;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"row", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int row
    {
      get { return _row; }
      set { _row = value; }
    }
    private int _col;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"col", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int col
    {
      get { return _col; }
      set { _col = value; }
    }
    private float _data;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RecordString")]
  public partial class RecordString : global::ProtoBuf.IExtensible
  {
    public RecordString() {}
    
    private int _row;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"row", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int row
    {
      get { return _row; }
      set { _row = value; }
    }
    private int _col;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"col", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int col
    {
      get { return _col; }
      set { _col = value; }
    }
    private byte[] _data;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RecordObject")]
  public partial class RecordObject : global::ProtoBuf.IExtensible
  {
    public RecordObject() {}
    
    private int _row;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"row", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int row
    {
      get { return _row; }
      set { _row = value; }
    }
    private int _col;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"col", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int col
    {
      get { return _col; }
      set { _col = value; }
    }
    private long _data;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ObjectRecordBase")]
  public partial class ObjectRecordBase : global::ProtoBuf.IExtensible
  {
    public ObjectRecordBase() {}
    
    private byte[] _record_name;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"record_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] record_name
    {
      get { return _record_name; }
      set { _record_name = value; }
    }
    private readonly global::System.Collections.Generic.List<NFMsg.RecordInt> _record_int_list = new global::System.Collections.Generic.List<NFMsg.RecordInt>();
    [global::ProtoBuf.ProtoMember(2, Name=@"record_int_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.RecordInt> record_int_list
    {
      get { return _record_int_list; }
    }
  
    private readonly global::System.Collections.Generic.List<NFMsg.RecordFloat> _record_float_list = new global::System.Collections.Generic.List<NFMsg.RecordFloat>();
    [global::ProtoBuf.ProtoMember(3, Name=@"record_float_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.RecordFloat> record_float_list
    {
      get { return _record_float_list; }
    }
  
    private readonly global::System.Collections.Generic.List<NFMsg.RecordString> _record_string_list = new global::System.Collections.Generic.List<NFMsg.RecordString>();
    [global::ProtoBuf.ProtoMember(4, Name=@"record_string_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.RecordString> record_string_list
    {
      get { return _record_string_list; }
    }
  
    private readonly global::System.Collections.Generic.List<NFMsg.RecordObject> _record_object_list = new global::System.Collections.Generic.List<NFMsg.RecordObject>();
    [global::ProtoBuf.ProtoMember(5, Name=@"record_object_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.RecordObject> record_object_list
    {
      get { return _record_object_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ObjectPropertyList")]
  public partial class ObjectPropertyList : global::ProtoBuf.IExtensible
  {
    public ObjectPropertyList() {}
    
    private long _player_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private readonly global::System.Collections.Generic.List<NFMsg.PropertyInt> _property_int_list = new global::System.Collections.Generic.List<NFMsg.PropertyInt>();
    [global::ProtoBuf.ProtoMember(2, Name=@"property_int_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.PropertyInt> property_int_list
    {
      get { return _property_int_list; }
    }
  
    private readonly global::System.Collections.Generic.List<NFMsg.PropertyFloat> _property_float_list = new global::System.Collections.Generic.List<NFMsg.PropertyFloat>();
    [global::ProtoBuf.ProtoMember(3, Name=@"property_float_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.PropertyFloat> property_float_list
    {
      get { return _property_float_list; }
    }
  
    private readonly global::System.Collections.Generic.List<NFMsg.PropertyString> _property_string_list = new global::System.Collections.Generic.List<NFMsg.PropertyString>();
    [global::ProtoBuf.ProtoMember(4, Name=@"property_string_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.PropertyString> property_string_list
    {
      get { return _property_string_list; }
    }
  
    private readonly global::System.Collections.Generic.List<NFMsg.PropertyObject> _property_object_list = new global::System.Collections.Generic.List<NFMsg.PropertyObject>();
    [global::ProtoBuf.ProtoMember(5, Name=@"property_object_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.PropertyObject> property_object_list
    {
      get { return _property_object_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MultiObjectPropertyList")]
  public partial class MultiObjectPropertyList : global::ProtoBuf.IExtensible
  {
    public MultiObjectPropertyList() {}
    
    private readonly global::System.Collections.Generic.List<NFMsg.ObjectPropertyList> _multi_player_property = new global::System.Collections.Generic.List<NFMsg.ObjectPropertyList>();
    [global::ProtoBuf.ProtoMember(1, Name=@"multi_player_property", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.ObjectPropertyList> multi_player_property
    {
      get { return _multi_player_property; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ObjectRecordList")]
  public partial class ObjectRecordList : global::ProtoBuf.IExtensible
  {
    public ObjectRecordList() {}
    
    private long _player_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private readonly global::System.Collections.Generic.List<NFMsg.ObjectRecordBase> _record_list = new global::System.Collections.Generic.List<NFMsg.ObjectRecordBase>();
    [global::ProtoBuf.ProtoMember(2, Name=@"record_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.ObjectRecordBase> record_list
    {
      get { return _record_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MultiObjectRecordList")]
  public partial class MultiObjectRecordList : global::ProtoBuf.IExtensible
  {
    public MultiObjectRecordList() {}
    
    private readonly global::System.Collections.Generic.List<NFMsg.ObjectRecordList> _multi_player_record = new global::System.Collections.Generic.List<NFMsg.ObjectRecordList>();
    [global::ProtoBuf.ProtoMember(1, Name=@"multi_player_record", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.ObjectRecordList> multi_player_record
    {
      get { return _multi_player_record; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ObjectPropertyInt")]
  public partial class ObjectPropertyInt : global::ProtoBuf.IExtensible
  {
    public ObjectPropertyInt() {}
    
    private long _player_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private readonly global::System.Collections.Generic.List<NFMsg.PropertyInt> _property_list = new global::System.Collections.Generic.List<NFMsg.PropertyInt>();
    [global::ProtoBuf.ProtoMember(2, Name=@"property_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.PropertyInt> property_list
    {
      get { return _property_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ObjectPropertyFloat")]
  public partial class ObjectPropertyFloat : global::ProtoBuf.IExtensible
  {
    public ObjectPropertyFloat() {}
    
    private long _player_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private readonly global::System.Collections.Generic.List<NFMsg.PropertyFloat> _property_list = new global::System.Collections.Generic.List<NFMsg.PropertyFloat>();
    [global::ProtoBuf.ProtoMember(2, Name=@"property_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.PropertyFloat> property_list
    {
      get { return _property_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ObjectPropertyString")]
  public partial class ObjectPropertyString : global::ProtoBuf.IExtensible
  {
    public ObjectPropertyString() {}
    
    private long _player_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private readonly global::System.Collections.Generic.List<NFMsg.PropertyString> _property_list = new global::System.Collections.Generic.List<NFMsg.PropertyString>();
    [global::ProtoBuf.ProtoMember(2, Name=@"property_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.PropertyString> property_list
    {
      get { return _property_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ObjectPropertyObject")]
  public partial class ObjectPropertyObject : global::ProtoBuf.IExtensible
  {
    public ObjectPropertyObject() {}
    
    private long _player_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private readonly global::System.Collections.Generic.List<NFMsg.PropertyObject> _property_list = new global::System.Collections.Generic.List<NFMsg.PropertyObject>();
    [global::ProtoBuf.ProtoMember(2, Name=@"property_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.PropertyObject> property_list
    {
      get { return _property_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ObjectRecordInt")]
  public partial class ObjectRecordInt : global::ProtoBuf.IExtensible
  {
    public ObjectRecordInt() {}
    
    private long _player_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private byte[] _record_name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"record_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] record_name
    {
      get { return _record_name; }
      set { _record_name = value; }
    }
    private readonly global::System.Collections.Generic.List<NFMsg.RecordInt> _property_list = new global::System.Collections.Generic.List<NFMsg.RecordInt>();
    [global::ProtoBuf.ProtoMember(3, Name=@"property_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.RecordInt> property_list
    {
      get { return _property_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ObjectRecordFloat")]
  public partial class ObjectRecordFloat : global::ProtoBuf.IExtensible
  {
    public ObjectRecordFloat() {}
    
    private long _player_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private byte[] _record_name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"record_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] record_name
    {
      get { return _record_name; }
      set { _record_name = value; }
    }
    private readonly global::System.Collections.Generic.List<NFMsg.RecordFloat> _property_list = new global::System.Collections.Generic.List<NFMsg.RecordFloat>();
    [global::ProtoBuf.ProtoMember(3, Name=@"property_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.RecordFloat> property_list
    {
      get { return _property_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ObjectRecordString")]
  public partial class ObjectRecordString : global::ProtoBuf.IExtensible
  {
    public ObjectRecordString() {}
    
    private long _player_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private byte[] _record_name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"record_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] record_name
    {
      get { return _record_name; }
      set { _record_name = value; }
    }
    private readonly global::System.Collections.Generic.List<NFMsg.RecordString> _property_list = new global::System.Collections.Generic.List<NFMsg.RecordString>();
    [global::ProtoBuf.ProtoMember(3, Name=@"property_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.RecordString> property_list
    {
      get { return _property_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ObjectRecordObject")]
  public partial class ObjectRecordObject : global::ProtoBuf.IExtensible
  {
    public ObjectRecordObject() {}
    
    private long _player_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private byte[] _record_name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"record_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] record_name
    {
      get { return _record_name; }
      set { _record_name = value; }
    }
    private readonly global::System.Collections.Generic.List<NFMsg.RecordObject> _property_list = new global::System.Collections.Generic.List<NFMsg.RecordObject>();
    [global::ProtoBuf.ProtoMember(3, Name=@"property_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.RecordObject> property_list
    {
      get { return _property_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ObjectRecordSwap")]
  public partial class ObjectRecordSwap : global::ProtoBuf.IExtensible
  {
    public ObjectRecordSwap() {}
    
    private long _player_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private byte[] _origin_record_name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"origin_record_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] origin_record_name
    {
      get { return _origin_record_name; }
      set { _origin_record_name = value; }
    }
    private byte[] _target_record_name = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"target_record_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] target_record_name
    {
      get { return _target_record_name; }
      set { _target_record_name = value; }
    }
    private int _row_origin;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"row_origin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int row_origin
    {
      get { return _row_origin; }
      set { _row_origin = value; }
    }
    private int _row_target;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"row_target", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int row_target
    {
      get { return _row_target; }
      set { _row_target = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RecordAddStruct")]
  public partial class RecordAddStruct : global::ProtoBuf.IExtensible
  {
    public RecordAddStruct() {}
    
    private int _row;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"row", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int row
    {
      get { return _row; }
      set { _row = value; }
    }
    private readonly global::System.Collections.Generic.List<NFMsg.RecordInt> _int_list = new global::System.Collections.Generic.List<NFMsg.RecordInt>();
    [global::ProtoBuf.ProtoMember(2, Name=@"int_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.RecordInt> int_list
    {
      get { return _int_list; }
    }
  
    private readonly global::System.Collections.Generic.List<NFMsg.RecordFloat> _float_list = new global::System.Collections.Generic.List<NFMsg.RecordFloat>();
    [global::ProtoBuf.ProtoMember(3, Name=@"float_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.RecordFloat> float_list
    {
      get { return _float_list; }
    }
  
    private readonly global::System.Collections.Generic.List<NFMsg.RecordString> _string_list = new global::System.Collections.Generic.List<NFMsg.RecordString>();
    [global::ProtoBuf.ProtoMember(4, Name=@"string_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.RecordString> string_list
    {
      get { return _string_list; }
    }
  
    private readonly global::System.Collections.Generic.List<NFMsg.RecordObject> _object_list = new global::System.Collections.Generic.List<NFMsg.RecordObject>();
    [global::ProtoBuf.ProtoMember(5, Name=@"object_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.RecordObject> object_list
    {
      get { return _object_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ObjectRecordAddRow")]
  public partial class ObjectRecordAddRow : global::ProtoBuf.IExtensible
  {
    public ObjectRecordAddRow() {}
    
    private long _player_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private byte[] _record_name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"record_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] record_name
    {
      get { return _record_name; }
      set { _record_name = value; }
    }
    private readonly global::System.Collections.Generic.List<NFMsg.RecordAddStruct> _row_data = new global::System.Collections.Generic.List<NFMsg.RecordAddStruct>();
    [global::ProtoBuf.ProtoMember(3, Name=@"row_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NFMsg.RecordAddStruct> row_data
    {
      get { return _row_data; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ObjectRecordRemove")]
  public partial class ObjectRecordRemove : global::ProtoBuf.IExtensible
  {
    public ObjectRecordRemove() {}
    
    private long _player_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private byte[] _record_name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"record_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] record_name
    {
      get { return _record_name; }
      set { _record_name = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _remove_row = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(3, Name=@"remove_row", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> remove_row
    {
      get { return _remove_row; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MsgBase")]
  public partial class MsgBase : global::ProtoBuf.IExtensible
  {
    public MsgBase() {}
    
    private int _player_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private byte[] _msg_data;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"msg_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] msg_data
    {
      get { return _msg_data; }
      set { _msg_data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqCommand")]
  public partial class ReqCommand : global::ProtoBuf.IExtensible
  {
    public ReqCommand() {}
    
    private long _control_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"control_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long control_id
    {
      get { return _control_id; }
      set { _control_id = value; }
    }
    private NFMsg.ReqCommand.EGameCommandType _command_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"command_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public NFMsg.ReqCommand.EGameCommandType command_id
    {
      get { return _command_id; }
      set { _command_id = value; }
    }
    private byte[] _command_str_value = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"command_str_value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] command_str_value
    {
      get { return _command_str_value; }
      set { _command_str_value = value; }
    }
    private long _command_value = default(long);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"command_value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long command_value
    {
      get { return _command_value; }
      set { _command_value = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"EGameCommandType")]
    public enum EGameCommandType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGCT_MODIY_PROPERTY", Value=0)]
      EGCT_MODIY_PROPERTY = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGCT_MODIY_ITEM", Value=1)]
      EGCT_MODIY_ITEM = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGCT_MODIY_TASK", Value=2)]
      EGCT_MODIY_TASK = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGCT_MODIY_CLONE", Value=3)]
      EGCT_MODIY_CLONE = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGCT_MODIY_KILL", Value=4)]
      EGCT_MODIY_KILL = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EGCT_SWAP_SCENE", Value=5)]
      EGCT_SWAP_SCENE = 5
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}