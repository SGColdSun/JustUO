namespace Server.Items
{
    public class LibraryApplication : Item
    {
        [Constructable]
        public LibraryApplication()
            : base(0xEC0)
        {
            LootType = LootType.Blessed;
            Weight = 1.0;
        }

        public LibraryApplication(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber
        {
            get { return 1073131; }
        } // Friends of the Library Application

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            var version = reader.ReadInt();
        }
    }
}