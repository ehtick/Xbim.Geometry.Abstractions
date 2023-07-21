﻿namespace Xbim.Geometry.Abstractions
{
    public interface IXAxisAlignedBoundingBox
    {
        IXPoint CornerMin { get; }
        IXPoint CornerMax { get; }
        double LenX { get; }
        double LenY { get; }
        double LenZ { get; }
        double Gap { get; }
        string Json { get; }
        IXAxisAlignedBoundingBox Union(IXAxisAlignedBoundingBox other);
        bool IsVoid { get; }
        IXPoint Centroid { get; }
        IXAxisAlignedBoundingBox Transformed(IXLocation location);
        IXAxisAlignedBoundingBox Translated(double xTranslation, double yTranslation, double zTranslation);
        IXAxisAlignedBoundingBox Translated(IXPoint translation);
    }
}