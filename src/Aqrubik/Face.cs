namespace Aqrubik {
    #region Using
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    #endregion Using
    /// <summary>
    /// Rubik face.
    /// </summary>
    [Flags]
    public enum Face : byte {
        None  = 0x00,
        Front = 0x01,
        Back  = 0x02,
        Left  = 0x04,
        Right = 0x08,
        Up    = 0x10,
        Down  = 0x20        
    }
}
