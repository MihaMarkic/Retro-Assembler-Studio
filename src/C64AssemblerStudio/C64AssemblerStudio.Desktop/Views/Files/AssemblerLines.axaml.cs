﻿using System.Collections.Frozen;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using C64AssemblerStudio.Engine.Models.Projects;
using C64AssemblerStudio.Engine.ViewModels.Files;
using Righthand.RetroDbgDataProvider.KickAssembler.Models;
using Righthand.RetroDbgDataProvider.Models.Program;
using BlockItem = Righthand.RetroDbgDataProvider.Models.Program.BlockItem;
using Label = Righthand.RetroDbgDataProvider.Models.Program.Label;

namespace C64AssemblerStudio.Desktop.Views.Files;

public partial class AssemblerLines : UserControl
{
    private IList<ByteDumpLineViewModel>? _lines;
    private ByteDumpLineViewModel? _contextLine;
    private ByteDumpLineViewModel? _executionLine;

    public static readonly DirectProperty<AssemblerLines, IList<ByteDumpLineViewModel>?> LinesProperty =
        AvaloniaProperty.RegisterDirect<AssemblerLines, IList<ByteDumpLineViewModel>?>(nameof(Lines), o => o.Lines,
            (o, v) => o.Lines = v);

    public static readonly DirectProperty<AssemblerLines, ByteDumpLineViewModel?> ContextLineProperty =
        AvaloniaProperty.RegisterDirect<AssemblerLines, ByteDumpLineViewModel?>(nameof(ContextLine), o => o.ContextLine,
            (o, v) => o.ContextLine = v);

    public static readonly DirectProperty<AssemblerLines, ByteDumpLineViewModel?> ExecutionLineProperty =
        AvaloniaProperty.RegisterDirect<AssemblerLines, ByteDumpLineViewModel?>(nameof(ExecutionLine),
            o => o.ExecutionLine,
            (o, v) => o.ExecutionLine = v);

    public AssemblerLines()
    {
        InitializeComponent();
        LinesGrid.LoadingRow += LinesGridOnLoadingRow;
        if (Design.IsDesignMode)
        {
            CreateDesignData();
        }
    }

    private void LinesGridOnLoadingRow(object? sender, DataGridRowEventArgs e)
    {
        var row = e.Row;
        //RowOnDataContextChanged(row);
        row.BindClass("highlight", new Binding
        {
            Path = nameof(ByteDumpLineViewModel.IsHighlighted),
            Source = row.DataContext,
        }, null!);
        row.BindClass("executive", new Binding
        {
            Path = nameof(ByteDumpLineViewModel.IsExecutive),
            Source = row.DataContext,
        }, null!);
    }

    public IList<ByteDumpLineViewModel>? Lines
    {
        get => _lines;
        set => SetAndRaise(LinesProperty, ref _lines, value);
    }

    public ByteDumpLineViewModel? ContextLine
    {
        get => _contextLine;
        set => SetAndRaise(ContextLineProperty, ref _contextLine, value);
    }

    public ByteDumpLineViewModel? ExecutionLine
    {
        get => _executionLine;
        set => SetAndRaise(ExecutionLineProperty, ref _executionLine, value);
    }

    private void CreateDesignData()
    {
        Lines = ImmutableArray<ByteDumpLineViewModel>.Empty.Add(
                    new ByteDumpLineViewModel(
                        new ByteDumpLine(
                            new AssemblyLine(0x8d00, ImmutableArray<byte>.Empty.Add(0x15).Add(0x60),
                                ImmutableArray<string>.Empty.Add("hello"), "ldy #44"),
                            new SourceFile(new SourceFilePath("relative/main.asm", true),
                                FrozenDictionary<string, Label>.Empty,
                                ImmutableArray<BlockItem>.Empty),
                            new MultiLineTextRange(new TextCursor(1, 5), new TextCursor(4, 5))),
                        belongsToFile: true))
                .Add(new ByteDumpLineViewModel(
                    new ByteDumpLine(
                        new AssemblyLine(0x8d04, ImmutableArray<byte>.Empty.Add(0x84),
                            ImmutableArray<string>.Empty.Add("hello"), "sta #55"),
                        new SourceFile(new SourceFilePath("other.asm", true),
                            FrozenDictionary<string, Label>.Empty,
                            ImmutableArray<BlockItem>.Empty),
                        new MultiLineTextRange(new TextCursor(2, 1), new TextCursor(2, 8))),
                    belongsToFile: false))
                .Add(new ByteDumpLineViewModel(
                    new ByteDumpLine(
                        new AssemblyLine(0x8d08, ImmutableArray<byte>.Empty.Add(0x84),
                            ImmutableArray<string>.Empty.Add("exec"), "exc 0"),
                        new SourceFile(new SourceFilePath("relative/main.asm", true),
                            FrozenDictionary<string, Label>.Empty,
                            ImmutableArray<BlockItem>.Empty),
                        new MultiLineTextRange(new TextCursor(2, 1), new TextCursor(2, 8))),
                    belongsToFile: true)
                {
                    IsExecutive = true,
                })
                .Add(new ByteDumpLineViewModel(
                    new ByteDumpLine(
                        new AssemblyLine(0x8d08, ImmutableArray<byte>.Empty.Add(0x84),
                            ImmutableArray<string>.Empty.Add("highlight"), "exc 0"),
                        new SourceFile(new SourceFilePath("relative/main.asm", true),
                            FrozenDictionary<string, Label>.Empty,
                            ImmutableArray<BlockItem>.Empty),
                        new MultiLineTextRange(new TextCursor(2, 1), new TextCursor(2, 8))),
                    belongsToFile: true)
                {
                    IsHighlighted = true,
                });
    }
}