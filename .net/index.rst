**************************************************
Conreality Software Development Kit (SDK) for .NET
**************************************************

The Conreality SDK for .NET is currently at an early development stage at:
https://github.com/conreality/conreality.net

.. note::

   Pending the release of a Conreality SDK for the .NET Framework, you can
   integrate C#/F#/.NET software with Conreality games by issuing SQL commands
   over the PostgreSQL network protocol (via the Npgsql_ PostgreSQL library).
   Refer to the documentation for the :doc:`Conreality SDK for SQL </sql/index>`.

Prerequisites
=============

* `Npgsql <https://www.nuget.org/packages/Npgsql/>`__ 3.2+

Examples
========

Connecting to the Master
------------------------

.. literalinclude:: examples/connect.cs
   :language: c#

Connecting to the Master (without the SDK)
------------------------------------------

.. literalinclude:: examples/lowlevel.cs
   :language: c#

Installation
============

https://www.nuget.org/packages/Conreality/

.. code-block:: console

   $ nuget install Conreality

Reference
=========

.. dotnet:assembly:: Conreality.dll

.. dotnet:namespace:: Conreality

.. code-block:: c#

   using Conreality;

.. dotnet:class:: Action

.. dotnet:class:: Client

.. dotnet:class:: Event

.. dotnet:class:: Game

.. dotnet:class:: Message

.. dotnet:class:: Object

.. dotnet:class:: Session

Frequently Asked Questions (FAQ)
================================

How can I help contribute to the development of the .NET SDK?
-------------------------------------------------------------

See https://github.com/conreality/conreality.net

Which .NET Framework version does the .NET SDK target?
------------------------------------------------------

The .NET SDK targets .NET 4.6 and C# 6. These are, not coincidentally, the
experimental API compatibility levels expected to ship with `Unity3D 2017.1
<https://unity3d.com/unity/roadmap>`__ (`based on Mono 4.8
<https://forum.unity3d.com/threads/future-plans-for-the-mono-runtime-upgrade.464327/>`__).

.. _Npgsql: http://www.npgsql.org/
