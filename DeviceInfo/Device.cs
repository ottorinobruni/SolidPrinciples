namespace DeviceInfo
{
    public class Device
    {
        public DeviceType Type { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }

        #region Life Mobile
        public string Sim { get; set; }
        #endregion

        #region Life Tablet
        public string Pencil { get; set; }
        #endregion

        #region Life Desktop
        public string Monitor { get; set; }
        #endregion
    }
}