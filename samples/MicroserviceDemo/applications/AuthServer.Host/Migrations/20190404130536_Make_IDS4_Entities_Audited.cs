﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthServer.Host.Migrations
{
    public partial class Make_IDS4_Entities_Audited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "IdentityServerIdentityResources",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "IdentityServerIdentityResources",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "IdentityServerIdentityResources",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "IdentityServerIdentityResources",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "IdentityServerIdentityResources",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "IdentityServerIdentityResources",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "IdentityServerIdentityResources",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LogoUri",
                table: "IdentityServerClients",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FrontChannelLogoutUri",
                table: "IdentityServerClients",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientUri",
                table: "IdentityServerClients",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BackChannelLogoutUri",
                table: "IdentityServerClients",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "IdentityServerClients",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "IdentityServerClients",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "IdentityServerClients",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "IdentityServerClients",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "IdentityServerClients",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "IdentityServerClients",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "IdentityServerClients",
                nullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "RedirectUri",
            //    table: "IdentityServerClientRedirectUris",
            //    maxLength: 200,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldMaxLength: 2000);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Value",
            //    table: "IdentityServerClientProperties",
            //    maxLength: 128,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldMaxLength: 2000);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Key",
            //    table: "IdentityServerClientProperties",
            //    maxLength: 64,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldMaxLength: 250);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "IdentityServerApiResources",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "IdentityServerApiResources",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "IdentityServerApiResources",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "IdentityServerApiResources",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "IdentityServerApiResources",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "IdentityServerApiResources",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "IdentityServerApiResources",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EntityTenantId",
                table: "AbpEntityChanges",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantName",
                table: "AbpAuditLogs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "IdentityServerIdentityResources");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "IdentityServerIdentityResources");

            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "IdentityServerIdentityResources");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "IdentityServerIdentityResources");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "IdentityServerIdentityResources");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "IdentityServerIdentityResources");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "IdentityServerIdentityResources");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "IdentityServerClients");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "IdentityServerClients");

            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "IdentityServerClients");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "IdentityServerClients");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "IdentityServerClients");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "IdentityServerClients");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "IdentityServerClients");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "IdentityServerApiResources");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "IdentityServerApiResources");

            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "IdentityServerApiResources");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "IdentityServerApiResources");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "IdentityServerApiResources");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "IdentityServerApiResources");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "IdentityServerApiResources");

            migrationBuilder.DropColumn(
                name: "EntityTenantId",
                table: "AbpEntityChanges");

            migrationBuilder.DropColumn(
                name: "TenantName",
                table: "AbpAuditLogs");

            migrationBuilder.AlterColumn<string>(
                name: "LogoUri",
                table: "IdentityServerClients",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FrontChannelLogoutUri",
                table: "IdentityServerClients",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientUri",
                table: "IdentityServerClients",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BackChannelLogoutUri",
                table: "IdentityServerClients",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 300,
                oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "RedirectUri",
            //    table: "IdentityServerClientRedirectUris",
            //    maxLength: 2000,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldMaxLength: 200);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Value",
            //    table: "IdentityServerClientProperties",
            //    maxLength: 2000,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldMaxLength: 128);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Key",
            //    table: "IdentityServerClientProperties",
            //    maxLength: 250,
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldMaxLength: 64);
        }
    }
}
