﻿using NServiceBus.Logging;

public class BuiltInConfig
{

    public void ChangingDefaults()
    {

        #region OverrideLoggingDefaultsInCode

        var defaultFactory = LogManager.Use<DefaultFactory>();
        defaultFactory.Directory("pathToLoggingDirectory");
        defaultFactory.Level(LogLevel.Debug);

        #endregion
    }
}