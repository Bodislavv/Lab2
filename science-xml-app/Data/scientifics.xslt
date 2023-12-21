<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="/">
		<html>
			<head>
				<title>Scientifics table</title>
				<style type="text/css">
					table {
					width: 100%;
					border-collapse: collapse;
					margin-top: 20px;
					}
					th, td {
					border: 1px solid #ddd;
					padding: 8px;
					text-align: left;
					}
					th {
					background-color: #f2f2f2;
					}
					h1 {
					text-align: center;
					}
				</style>
			</head>
			<body>
				<h1>Scientific Achievements table</h1>
				<table>
					<tr>
						<th>ID</th>
						<th>FullName</th>
						<th>Faculcy</th>
						<th>Cafedra</th>
						<th>Level</th>
						<th>WhenGotLevel</th>
					</tr>
					<xsl:apply-templates select="Scientifics/Scientific"/>
				</table>
			</body>
		</html>
	</xsl:template>

	<xsl:template match="Scientific">
		<tr>
			<td>
				<xsl:value-of select="Id"/>
			</td>
			<td>
				<xsl:value-of select="FullName"/>
			</td>
			<td>
				<xsl:value-of select="Faculcy"/>
			</td>
			<td>
				<xsl:value-of select="Cafedra"/>
			</td>
			<td>
				<xsl:value-of select="Level"/>
			</td>
			<td>
				<xsl:value-of select="WhenGotLevel"/>
			</td>
		</tr>
	</xsl:template>

</xsl:stylesheet>
