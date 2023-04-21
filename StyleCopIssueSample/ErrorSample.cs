// <copyright file="ErrorSample.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace StyleCopIssueSample;

using System.Collections.Generic;

/// <summary>
/// A sample.
/// </summary>
public class ErrorSample
{
    /// <summary>
    /// Error sample Zero.
    /// </summary>
    public static readonly ErrorSample Default = new(0, 0, 0);

    /// <summary>
    /// Initializes a new instance of the <see cref="ErrorSample"/> class.
    /// </summary>
    /// <param name="q">
    /// The Q axis location.
    /// </param>
    /// <param name="r">
    /// The R axis location.
    /// </param>
    /// <param name="s">
    /// The S axis location.
    /// </param>
    public ErrorSample(int q, int r, int s)
    {
        this.Q = q;
        this.R = r;
        this.S = s;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ErrorSample"/> class.
    /// </summary>
    /// <param name="q">
    /// The Q position.
    /// </param>
    /// <param name="r">
    /// The R position.
    /// </param>
    public ErrorSample(int q, int r)
    {
        this.Q = q;
        this.R = r;
        this.S = -q - r;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ErrorSample"/> class.
    /// </summary>
    public ErrorSample()
    {
    }

    /// <summary>
    /// Gets or sets the q axis value.
    /// </summary>
    public int Q { get; set; } = 0;

    /// <summary>
    /// Gets or sets the r axis value.
    /// </summary>
    public int R { get; set; } = 0;

    /// <summary>
    /// Gets or sets the s axis value.
    /// </summary>
    public int S { get; set; } = 0;

    /// <inheritdoc/>
    public override string ToString() => $"[{this.Q} {this.R} {this.S}]";
}
