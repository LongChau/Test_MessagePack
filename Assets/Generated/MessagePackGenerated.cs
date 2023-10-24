// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY MPC(MessagePack-CSharp). DO NOT CHANGE IT.
// </auto-generated>

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
#pragma warning disable CS1591 // document public APIs

#pragma warning disable SA1312 // Variable names should begin with lower-case letter
#pragma warning disable SA1649 // File name should match first type name

namespace MessagePack.Resolvers
{
    public class GeneratedResolver : global::MessagePack.IFormatterResolver
    {
        public static readonly global::MessagePack.IFormatterResolver Instance = new GeneratedResolver();

        private GeneratedResolver()
        {
        }

        public global::MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>()
        {
            return FormatterCache<T>.Formatter;
        }

        private static class FormatterCache<T>
        {
            internal static readonly global::MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

            static FormatterCache()
            {
                var f = GeneratedResolverGetFormatterHelper.GetFormatter(typeof(T));
                if (f != null)
                {
                    Formatter = (global::MessagePack.Formatters.IMessagePackFormatter<T>)f;
                }
            }
        }
    }

    internal static class GeneratedResolverGetFormatterHelper
    {
        private static readonly global::System.Collections.Generic.Dictionary<global::System.Type, int> lookup;

        static GeneratedResolverGetFormatterHelper()
        {
            lookup = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(5)
            {
                { typeof(global::System.Collections.Generic.Dictionary<global::Test.CharacterType, int>), 0 },
                { typeof(global::System.Collections.Generic.List<global::Test.Building>), 1 },
                { typeof(global::Test.CharacterType), 2 },
                { typeof(global::Test.Building), 3 },
                { typeof(global::Test.UserData), 4 },
            };
        }

        internal static object GetFormatter(global::System.Type t)
        {
            int key;
            if (!lookup.TryGetValue(t, out key))
            {
                return null;
            }

            switch (key)
            {
                case 0: return new global::MessagePack.Formatters.DictionaryFormatter<global::Test.CharacterType, int>();
                case 1: return new global::MessagePack.Formatters.ListFormatter<global::Test.Building>();
                case 2: return new MessagePack.Formatters.Test_CharacterTypeFormatter();
                case 3: return new MessagePack.Formatters.Test_BuildingFormatter();
                case 4: return new MessagePack.Formatters.Test_UserDataFormatter();
                default: return null;
            }
        }
    }
}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning restore SA1312 // Variable names should begin with lower-case letter
#pragma warning restore SA1649 // File name should match first type name


// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY MPC(MessagePack-CSharp). DO NOT CHANGE IT.
// </auto-generated>

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
#pragma warning disable CS1591 // document public APIs

#pragma warning disable SA1403 // File may only contain a single namespace
#pragma warning disable SA1649 // File name should match first type name

namespace MessagePack.Formatters
{

    public sealed class Test_CharacterTypeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::Test.CharacterType>
    {
        public void Serialize(ref global::MessagePack.MessagePackWriter writer, global::Test.CharacterType value, global::MessagePack.MessagePackSerializerOptions options)
        {
            writer.Write((global::System.Int32)value);
        }

        public global::Test.CharacterType Deserialize(ref global::MessagePack.MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            return (global::Test.CharacterType)reader.ReadInt32();
        }
    }
}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning restore SA1403 // File may only contain a single namespace
#pragma warning restore SA1649 // File name should match first type name



// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY MPC(MessagePack-CSharp). DO NOT CHANGE IT.
// </auto-generated>

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
#pragma warning disable CS1591 // document public APIs

#pragma warning disable SA1129 // Do not use default value type constructor
#pragma warning disable SA1309 // Field names should not begin with underscore
#pragma warning disable SA1312 // Variable names should begin with lower-case letter
#pragma warning disable SA1403 // File may only contain a single namespace
#pragma warning disable SA1649 // File name should match first type name

namespace MessagePack.Formatters
{
    public sealed class Test_BuildingFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::Test.Building>
    {
        // name
        private static global::System.ReadOnlySpan<byte> GetSpan_name() => new byte[1 + 4] { 164, 110, 97, 109, 101 };

        public void Serialize(ref global::MessagePack.MessagePackWriter writer, global::Test.Building value, global::MessagePack.MessagePackSerializerOptions options)
        {
            var formatterResolver = options.Resolver;
            writer.WriteMapHeader(1);
            writer.WriteRaw(GetSpan_name());
            global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<string>(formatterResolver).Serialize(ref writer, value.name, options);
        }

        public global::Test.Building Deserialize(ref global::MessagePack.MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                throw new global::System.InvalidOperationException("typecode is null, struct not supported");
            }

            options.Security.DepthStep(ref reader);
            var formatterResolver = options.Resolver;
            var length = reader.ReadMapHeader();
            var ____result = new global::Test.Building();

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.Internal.CodeGenHelpers.ReadStringSpan(ref reader);
                switch (stringKey.Length)
                {
                    default:
                    FAIL:
                      reader.Skip();
                      continue;
                    case 4:
                        if (global::MessagePack.Internal.AutomataKeyGen.GetKey(ref stringKey) != 1701667182UL) { goto FAIL; }

                        ____result.name = global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<string>(formatterResolver).Deserialize(ref reader, options);
                        continue;

                }
            }

            reader.Depth--;
            return ____result;
        }
    }

    public sealed class Test_UserDataFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::Test.UserData>
    {
        // name
        private static global::System.ReadOnlySpan<byte> GetSpan_name() => new byte[1 + 4] { 164, 110, 97, 109, 101 };
        // password
        private static global::System.ReadOnlySpan<byte> GetSpan_password() => new byte[1 + 8] { 168, 112, 97, 115, 115, 119, 111, 114, 100 };
        // email
        private static global::System.ReadOnlySpan<byte> GetSpan_email() => new byte[1 + 5] { 165, 101, 109, 97, 105, 108 };
        // age
        private static global::System.ReadOnlySpan<byte> GetSpan_age() => new byte[1 + 3] { 163, 97, 103, 101 };
        // city
        private static global::System.ReadOnlySpan<byte> GetSpan_city() => new byte[1 + 4] { 164, 99, 105, 116, 121 };
        // ownChars
        private static global::System.ReadOnlySpan<byte> GetSpan_ownChars() => new byte[1 + 8] { 168, 111, 119, 110, 67, 104, 97, 114, 115 };
        // buildings
        private static global::System.ReadOnlySpan<byte> GetSpan_buildings() => new byte[1 + 9] { 169, 98, 117, 105, 108, 100, 105, 110, 103, 115 };

        public void Serialize(ref global::MessagePack.MessagePackWriter writer, global::Test.UserData value, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (value is null)
            {
                writer.WriteNil();
                return;
            }

            var formatterResolver = options.Resolver;
            writer.WriteMapHeader(7);
            writer.WriteRaw(GetSpan_name());
            global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<string>(formatterResolver).Serialize(ref writer, value.name, options);
            writer.WriteRaw(GetSpan_password());
            global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<string>(formatterResolver).Serialize(ref writer, value.password, options);
            writer.WriteRaw(GetSpan_email());
            global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<string>(formatterResolver).Serialize(ref writer, value.email, options);
            writer.WriteRaw(GetSpan_age());
            writer.Write(value.age);
            writer.WriteRaw(GetSpan_city());
            global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<string>(formatterResolver).Serialize(ref writer, value.city, options);
            writer.WriteRaw(GetSpan_ownChars());
            global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<global::System.Collections.Generic.Dictionary<global::Test.CharacterType, int>>(formatterResolver).Serialize(ref writer, value.ownChars, options);
            writer.WriteRaw(GetSpan_buildings());
            global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<global::System.Collections.Generic.List<global::Test.Building>>(formatterResolver).Serialize(ref writer, value.buildings, options);
        }

        public global::Test.UserData Deserialize(ref global::MessagePack.MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return null;
            }

            options.Security.DepthStep(ref reader);
            var formatterResolver = options.Resolver;
            var length = reader.ReadMapHeader();
            var ____result = new global::Test.UserData();

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.Internal.CodeGenHelpers.ReadStringSpan(ref reader);
                switch (stringKey.Length)
                {
                    default:
                    FAIL:
                      reader.Skip();
                      continue;
                    case 4:
                        switch (global::MessagePack.Internal.AutomataKeyGen.GetKey(ref stringKey))
                        {
                            default: goto FAIL;
                            case 1701667182UL:
                                ____result.name = global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<string>(formatterResolver).Deserialize(ref reader, options);
                                continue;
                            case 2037672291UL:
                                ____result.city = global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<string>(formatterResolver).Deserialize(ref reader, options);
                                continue;
                        }
                    case 8:
                        switch (global::MessagePack.Internal.AutomataKeyGen.GetKey(ref stringKey))
                        {
                            default: goto FAIL;
                            case 7237970109966541168UL:
                                ____result.password = global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<string>(formatterResolver).Deserialize(ref reader, options);
                                continue;
                            case 8318818562142533487UL:
                                ____result.ownChars = global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<global::System.Collections.Generic.Dictionary<global::Test.CharacterType, int>>(formatterResolver).Deserialize(ref reader, options);
                                continue;
                        }
                    case 5:
                        if (global::MessagePack.Internal.AutomataKeyGen.GetKey(ref stringKey) != 465624460645UL) { goto FAIL; }

                        ____result.email = global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<string>(formatterResolver).Deserialize(ref reader, options);
                        continue;
                    case 3:
                        if (global::MessagePack.Internal.AutomataKeyGen.GetKey(ref stringKey) != 6645601UL) { goto FAIL; }

                        ____result.age = reader.ReadInt32();
                        continue;
                    case 9:
                        if (!global::System.MemoryExtensions.SequenceEqual(stringKey, GetSpan_buildings().Slice(1))) { goto FAIL; }

                        ____result.buildings = global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<global::System.Collections.Generic.List<global::Test.Building>>(formatterResolver).Deserialize(ref reader, options);
                        continue;

                }
            }

            reader.Depth--;
            return ____result;
        }
    }

}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning restore SA1129 // Do not use default value type constructor
#pragma warning restore SA1309 // Field names should not begin with underscore
#pragma warning restore SA1312 // Variable names should begin with lower-case letter
#pragma warning restore SA1403 // File may only contain a single namespace
#pragma warning restore SA1649 // File name should match first type name

