using System;
using System.Collections.Generic;
using System.Text;

namespace MumbleSharp.Audio
{
    //
    // Summary:
    //     Generic interface for all WaveProviders.
    public interface IWaveProvider
    {
        //
        // Summary:
        //     Gets the WaveFormat of this WaveProvider.
        //
        // Value:
        //     The wave format.
        WaveFormat WaveFormat { get; }

        //
        // Summary:
        //     Fill the specified buffer with wave data.
        //
        // Parameters:
        //   buffer:
        //     The buffer to fill of wave data.
        //
        //   offset:
        //     Offset into buffer
        //
        //   count:
        //     The number of bytes to read
        //
        // Returns:
        //     the number of bytes written to the buffer.
        int Read(byte[] buffer, int offset, int count);
    }
}
