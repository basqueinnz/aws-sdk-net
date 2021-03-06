/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Contains details for the backup.
    /// </summary>
    public partial class BackupSummary
    {
        private string _backupArn;
        private DateTime? _backupCreationDateTime;
        private string _backupName;
        private long? _backupSizeBytes;
        private BackupStatus _backupStatus;
        private string _tableArn;
        private string _tableId;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property BackupArn. 
        /// <para>
        /// ARN associated with the backup.
        /// </para>
        /// </summary>
        public string BackupArn
        {
            get { return this._backupArn; }
            set { this._backupArn = value; }
        }

        // Check to see if BackupArn property is set
        internal bool IsSetBackupArn()
        {
            return this._backupArn != null;
        }

        /// <summary>
        /// Gets and sets the property BackupCreationDateTime. 
        /// <para>
        /// Time at which the backup was created.
        /// </para>
        /// </summary>
        public DateTime BackupCreationDateTime
        {
            get { return this._backupCreationDateTime.GetValueOrDefault(); }
            set { this._backupCreationDateTime = value; }
        }

        // Check to see if BackupCreationDateTime property is set
        internal bool IsSetBackupCreationDateTime()
        {
            return this._backupCreationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BackupName. 
        /// <para>
        /// Name of the specified backup.
        /// </para>
        /// </summary>
        public string BackupName
        {
            get { return this._backupName; }
            set { this._backupName = value; }
        }

        // Check to see if BackupName property is set
        internal bool IsSetBackupName()
        {
            return this._backupName != null;
        }

        /// <summary>
        /// Gets and sets the property BackupSizeBytes. 
        /// <para>
        /// Size of the backup in bytes.
        /// </para>
        /// </summary>
        public long BackupSizeBytes
        {
            get { return this._backupSizeBytes.GetValueOrDefault(); }
            set { this._backupSizeBytes = value; }
        }

        // Check to see if BackupSizeBytes property is set
        internal bool IsSetBackupSizeBytes()
        {
            return this._backupSizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BackupStatus. 
        /// <para>
        /// Backup can be in one of the following states: CREATING, ACTIVE, DELETED.
        /// </para>
        /// </summary>
        public BackupStatus BackupStatus
        {
            get { return this._backupStatus; }
            set { this._backupStatus = value; }
        }

        // Check to see if BackupStatus property is set
        internal bool IsSetBackupStatus()
        {
            return this._backupStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TableArn. 
        /// <para>
        /// ARN associated with the table.
        /// </para>
        /// </summary>
        public string TableArn
        {
            get { return this._tableArn; }
            set { this._tableArn = value; }
        }

        // Check to see if TableArn property is set
        internal bool IsSetTableArn()
        {
            return this._tableArn != null;
        }

        /// <summary>
        /// Gets and sets the property TableId. 
        /// <para>
        /// Unique identifier for the table.
        /// </para>
        /// </summary>
        public string TableId
        {
            get { return this._tableId; }
            set { this._tableId = value; }
        }

        // Check to see if TableId property is set
        internal bool IsSetTableId()
        {
            return this._tableId != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// Name of the table.
        /// </para>
        /// </summary>
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

    }
}