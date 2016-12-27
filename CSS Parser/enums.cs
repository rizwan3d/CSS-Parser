﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoCssParser
{
    /// <summary>
    /// Deffine Tag type. 
    /// </summary>
    public enum TagType
    {
        /// <summary>
        /// Normal HTMl Tag.
        /// </summary>
        Tag,
        /// <summary>
        /// Class in HTML Code.
        /// </summary>
        Class,
        /// <summary>
        /// Tag in HTML Code.
        /// </summary>
        Id
    }

    /// <summary>
    /// HTML Tags. 
    /// </summary>
    public enum Tag
    {
        h1, h2, h3, h4, h5, h6, body, a, img, ol, ul, li, table, tr, th, nav, heder, footer, form, option, select, button, textarea, input, audio, video, iframe, hr, em, div, pre, p,span
    }

    /// <summary>
    /// Css properties list.
    /// </summary>
    public enum CssProperty
    {
                FontWeight, BorderRadius, ColorStop, AlignmentAdjust,AlignmentBaseLine
                ,Animation,AnimationDelay,AnimationDirection,AnimationDuration,AnimationIterationCount
                ,Animationname,AnimationPlayState,AnimationTimingFunction,Appearance,Azimuth
                ,BackfaceVisibility,Background,BackgroundAttachment,BackgroundBreak,BackgroundClip
                ,BackgroundColor,BackgroundImage,BackgroundOrigin,BackgroundPosition,BackgroundRepeat
                ,BackgroundSize,BaseLineShift,Binding,Bleed,BookMarkLabel,BookMarkLevel,BookMarkState
                ,BookMarkTarget,Border,BorderBottom,BorderBottomColor,BorderBottomLeftRadius
                ,BorderBottomRightRadius,BorderBottomStyle,BorderBottomWidth,BorderCollapse
                ,BorderColor,BorderImage,BorderImageOutSet,BorderImageRepeat,BorderImageSlice
                ,BorderImageSource,BorderImageWidth,BorderLeft,BorderLeftColor,BorderLeftStyle
                ,BorderLeftWidth,BorderRight,BorderRightColor,BorderRightStyle,BorderRightWidth
                ,BorderSpacing,BorderStyle,BorderTop,BorderTopColor,BorderTopLeftRadius
                ,BorderTopRightRadius,BorderTopStyle,BorderTopWidth,BorderWidth,Bottom,BoxAlign
                ,BoxDecorationBreak,BoxDirection,BoxFlex,BoxFlexGroup,BoxLines,BoxordinalGroup
                ,BoxOrient,BoxPack,BoxShadow,BoxSizing,BreakAfter,BreakBefore,BreakInSide
                ,CaptionSide,Clear,Clip,Color,ColorProfile,ColumnCount,ColumnFill,ColumnGap
                ,ColumnRule,ColumnRuleColor,ColumnRuleStyle,ColumnRuleWidth,ColumnSpan
                ,ColumnWidth,Columns,Content,CounterIncrement,CounTerreset,Crop,Cue,CueAfter
                ,CueBefore,Cursor,Direction,DisPlay,DominantBaseLine,DropInitialAfteradJust
                ,DropInitialAfterAlign,DropInitialBeforeadJust,DropInitialBeforeAlign
                ,DropInitialSize,DropInitialValue,Elevation,EmptyCells,Filter,Fit,FitPosition
                ,floatOffSet,Font,FontEffect,FontEmphaSize,FontFamily,FontSize
                ,FontSizeadJust,FontStretch,FontStyle, FontVariant, GridColumns,GridRows
                ,HangingPunctuation,Height,HyphenateAfter,HyphenateBefore,HyphenateCharacter
                ,HyphenateLines,HyphenatereSource,Hyphens,Icon,ImageOrientation,ImageRendering
                ,ImagereSolution,InLineBoxAlign,Left,LetterSpacing,LineHeight,LineStacking
                ,LineStackingRuby,LineStackingShift,LineStackingStrategy,LlistStyle,LlistStyleImage
                ,LlistStylePosition,LlistStyleType,Margin,MarginBottom,MarginLeft,MarginRight
                ,MarginTop,Mark,MarkAfter,MarkBefore,MarkerOffSet,Marks,MarqueeDirection
                ,MarqueePlayCount,MarqueeSpeed,MarqueeStyle,MaxHeight,MaxWidth,MinHeight
                ,MinWidth,MoveTo,NavDown,NavIndex,NavLeft,NavRight,NavUp,Opacity,Orphans
                ,OutLine,OutLineColor,OutLineOffSet,OutLineStyle,OutLineWidth,OverFlow,OverFlowStyle
                ,OverFlowx,OverFlowy,padding,paddingBottom,paddingLeft,paddingRight,paddingTop,Page
                ,PageBreakAfter,PageBreakBefore,PageBreakInSide,PagePolicy, Pause, PauseAfter
                ,PauseBefore,Perspective,PerspectiveOrigin,Phonemes,Pitch,PitchRange,PlayDuring
                ,Position,presentationLevel,Punctuationtrim,quotes,Renderingintent,reSize,Rest
                ,RestAfter,RestBefore,Richness,Right,Rotation,RotationPoint,RubyAlign,RubyOverhang
                ,RubyPosition,RubySpan,Size,Speak,SpeakHeader,SpeakNumeral,SpeakPunctuation,SpeechRate
                ,Stress,StringSet,TablelayOut,Target,Targetname,TargetNew,TargetPosition
                ,TextAlign,TextAlignlast,TextDecoration,TextEmphasis,TextHeight,TextIndent
                ,TextJustify,TextOutLine,TextOverFlow,TextShadow,TextTransform,Textwrap,Top
                ,Transform,TransformOrigin,TransformStyle,Transition,TransitionDelay,TransitionDuration
                ,TransitionProperty,TransitiontiMingFunction,unicodebidi,VerticalAlign,Visibility
                ,VoiceBalance,VoiceDuration,VoiceFamily,VoicePitch,VoicePitchRange,Voicerate
                ,VoiceStress,VoiceVolume,Volume,WhiteSpace,WhiteSpaceCollapse,Widows,Width,WordBreak
                ,WordSpacing,WordWrap,LinearGradient,ColorDodge,Center,ContentBox
                ,Scroll,Hidden,WebKitFlex,RowReverse,Flex,SpaceAround
                ,FirstJustify,InterWord,UpperCase,LowerCase,Capitalize,Nowrap,BreakAll,BreakWord,OverLine
                ,LineThrough,Wavy,MyFirstFont,Sensation               
    }
}
