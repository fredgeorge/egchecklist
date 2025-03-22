/*
 * Copyright (c) 2025 by Fred George
 * May be used freely except for training; license required for training.
 * @author Fred George  fredgeorge@acm.org
 */

namespace Engine.Checklists;

// Understands something that needs an Answer
public interface Item {
    ItemStatus Status();

    void Be(object value);

    void Reset();
}