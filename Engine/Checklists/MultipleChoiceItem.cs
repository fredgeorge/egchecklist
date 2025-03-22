/*
 * Copyright (c) 2025 by Fred George
 * May be used freely except for training; license required for training.
 * @author Fred George  fredgeorge@acm.org
 */

using static Engine.Checklists.ItemStatus;

namespace Engine.Checklists;

// Understands selecting from a limited list
public class MultipleChoiceItem : Item{
    private readonly List<object> _choices;
    private object? _value;

    public MultipleChoiceItem(params object[] choices) {
        _choices = choices.ToList();
    }

    public ItemStatus Status() {
        if (_value == null) return Unknown;
        return _choices.Contains(_value) ? Happy : Sad;
    }

    public void Be(object value) {
        _value = value;
    }

    public void Reset() => _value = null;
}