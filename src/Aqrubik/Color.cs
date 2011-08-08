namespace Aqrubik {
    #region Using
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    #endregion Using
    /// <summary>
    /// Rubik color.
    /// </summary>
    [Flags]
    public enum Color {
        None   = 0x00,
        Blue   = 0x01,
        Green  = 0x02,
        Orange = 0x04,
        Red    = 0x08,
        Yellow = 0x10,
        White  = 0x20
    }
}
