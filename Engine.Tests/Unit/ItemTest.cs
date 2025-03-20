/*
 * Copyright (c) 2025 by Fred George
 * May be used freely except for training; license required for training.
 * @author Fred George  fredgeorge@acm.org
 */

using System.Threading;
using Engine.Checklists;
using static Engine.Checklists.ItemStatus;
using static Engine.Tests.Unit.Choices;

using Xunit;

namespace Engine.Tests.Unit;

// Ensures each Item works correctly
public class ItemTest {
    [Fact]
    public void TrueFalseItemCheck() {
        var item = new TrueFalseItem();
        Assert.Equal(Unknown, item.Status());
        item.Be(true);
        Assert.Equal(Happy, item.Status());
        item.Be(false);
        Assert.Equal(Sad, item.Status());
        item.Reset();
        Assert.Equal(Unknown, item.Status());
    }

    [Fact]
    public void MultipleItemCheck() {
        var item = new MultipleChoiceItem(A, B, C);
        Assert.Equal(Unknown, item.Status());
        item.Be(A);
        Assert.Equal(Happy, item.Status());
        item.Be(D);
        Assert.Equal(Sad, item.Status());
        item.Reset();
        Assert.Equal(Unknown, item.Status());
    }
}

internal enum Choices {
    A, B, C, D
}