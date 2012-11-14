

--   OBJREPORTES_REGISTROVENTAS '001', '201001', '201001', 'N', '', 0
ALTER PROCEDURE [dbo].[OBJREPORTES_REGISTROVENTAS_SUNAT] 

			@IDEMPRESA    CHAR(3),-- CÓDIGO DE LA EMPRESA
            @PERIODODESDE CHAR(6),-- DESDE (YYYYMMDD)
            @PERIODOHASTA CHAR(6),-- HASTA (YYYYMMDD)
            @TIPOMONEDA   CHAR(1),-- [N]ACIONAL O [E]XTRANJERA
            @AMBITO       CHAR(3),-- AMBITO DE DOCUMENTOS
            @PORCUENTA    NUMERIC(1) -- REGISTRO DE VENTAS POR CUENTA (1):SI, (0):NO
AS
      SET FMTONLY OFF
      SET NOCOUNT ON
    DECLARE @IDREFERENCIA    CHAR(15),
            @VENTANA         VARCHAR(30),
            @FECHA           DATETIME,
            @IDDOCUMENTO     CHAR(3),
            @NUMDOCUMENTO    VARCHAR(15),
            @RUC             VARCHAR(11),
            @RAZON_SOCIAL    VARCHAR(100),
            @BASEIMP_AFEC    DECIMAL(17, 2),
            @BASEIMP_EXON    DECIMAL(17, 2),
            @BASEIMP_EXPO    DECIMAL(17, 2),
            @INAFECTO        DECIMAL(17, 2),
            @ISC             NUMERIC(17, 2),
            @IMPTO_AFEC      DECIMAL(17, 2),
            @IMPTO_EXON      DECIMAL(17, 2),
            @OTROS           DECIMAL(17, 2),
            @DIFERENCIA      NUMERIC(17, 4),
            @MONEDA          VARCHAR(10),
            @TCAMBIO         DECIMAL(12, 4),
            @TCMONEDA        DECIMAL(12, 6),
            @IDIMPUESTO      CHAR(3),
            @REGAGRICOLA     INT,
            @EXPORTACION     INT,
            @FACTOR          NUMERIC(1),
            @TIPO_MONEDA     CHAR(1),
            @VVENTA          DECIMAL(17, 2),
            @IMPUESTO        DECIMAL(17, 2),
            @DESCUENTO       DECIMAL(17, 2),
            @TOTAL           DECIMAL(17, 2),
            @IDESTADO        CHAR(2),
            @IGV             DECIMAL(8, 4),
            @PARAMETRO       VARCHAR(10),
            @ANTICIPO        DECIMAL(17, 2),
            @TOTALUS         DECIMAL(17, 2),
            @IDCUENTA        CHAR(12),
            @DESCRIPCION     VARCHAR(100),
            @IDTIPOVENTA     CHAR(3),
            @IDSUCURSAL      CHAR(3),
            @GASTOS          NUMERIC(17, 2),
            @DSC_DOCUMENTO   VARCHAR(50),
            @VOUCHER         VARCHAR(20),
            @DOC_SUNAT       CHAR(2),
            @PERIODO         CHAR(6),
            @DOC_REFE        VARCHAR(16),
            @OTRAREFE        CHAR(15),
            @IDCLIENTE       CHAR(11),
            @FECHAREFER      DATETIME,
            @TIPOREFER       CHAR(2),
            @SERIEREFER      CHAR(4),
            @NUMEROREFER     CHAR(7),
            @TIPOPERSONA     CHAR(2),
            @VENCIMIENTO     DATETIME,
            @IDCONTABILIZADO VARCHAR(15),
            @DOC_DEB_CRED    VARCHAR(200)
  BEGIN
      CREATE TABLE #REGISTROVENTAS
        (
           IDREFERENCIA     CHAR(15),
           VENTANA          VARCHAR(30),
           FECHA            DATETIME,
           IDDOCUMENTO      CHAR(3),
           NUMDOCUMENTO     VARCHAR(15),
           RUC              VARCHAR(11),
           RAZON_SOCIAL     VARCHAR(100),
           BASEIMP_AFEC     DECIMAL(17, 2),
           BASEIMP_EXPO     DECIMAL(17, 2),
           BASEIMP_EXON     DECIMAL(17, 2),
           INAFECTO         DECIMAL(17, 2),
           ISC              DECIMAL(17, 2),
           IMPTO_AFEC       DECIMAL(17, 2),
           IMPTO_EXON       DECIMAL(17, 2),
           OTROS            DECIMAL(17, 2),
           TOTAL            DECIMAL(17, 2),
           MONEDA           VARCHAR(10),
           TCAMBIO          DECIMAL(12, 4),
           IGV              DECIMAL(12, 4),
           TOTALUS          DECIMAL(17, 2),
           IDSUCURSAL       CHAR(3),
           DSC_DOCUMENTO    VARCHAR(50),
           COMPROBANTE      VARCHAR(20),
           IDTIPOVENTA      CHAR(3),
           DOC_SUNAT        CHAR(2),
           PERIODO          CHAR(6),
           DOC_REFE         CHAR(16),
           IDCLIEPROV       CHAR(11),
           GASTOS_VENTAS    NUMERIC (18, 4),
           TIPOPERSONA      CHAR(2),
           FECHAREFER       DATETIME,
           TIPOREFER        CHAR(2),
           SERIEREFER       CHAR(4),
           NUMEROREFER      CHAR(7),
           VENCIMIENTO      DATETIME,
           TD               VARCHAR(2),
           IDCONTABILIZADO  CHAR(15),
           IDEMPRESA        CHAR(3),
           IDCOBRARPAGARDOC CHAR(15)
        )
      DECLARE A CURSOR FOR
        SELECT C.IDSUCURSAL,
               C.IDCOBRARPAGARDOC,
               C.IDTIPOVENTA,
               C.IDDOCUMENTO,
               ISNULL(C.SERIE, '') + ' - ' + ISNULL(C.NUMERO, ''),
               C.FECHA,
               C.IDOPERACION + ' ' + C.NUMOPERACION,
               P.RAZON_SOCIAL,
               ISNULL(P.IDCLIEPROV, ''),
               CASE LEN(RTRIM(ISNULL(P.RUC, '')))
                 WHEN 0 THEN ISNULL(P.DNI, '')
                 ELSE ISNULL(P.RUC, '')
               END,
               D.DESCRIPCION,
               M.TIPO_MONEDA,
               M.NOMBRE_CORTO,
               ISNULL(C.TCAMBIO, 1),
               C.TCMONEDA,
               C.VENTANA,
               ISNULL(C.REGAGRICOLA, 0),
               ISNULL(C.EXPORTACION, 0),
               C.IDESTADO,
               ISNULL(D.FACTOR, 1),
               ISNULL(C.VVENTA, 0),
               ISNULL(C.DESCUENTO + C.DESCUENTODOC, 0),
               ISNULL(C.INAFECTO, 0),
               ISNULL(C.IMPORTE, 0),
               D.CODIGO_SUNAT,
               C.PERIODO,
               CASE LEN(RTRIM(ISNULL(P.RUC, '')))
                 WHEN 0 THEN ISNULL(P.IDDOCIDENTIDAD, '')
                 ELSE '06'
               END,
               C.VENCIMIENTO,
               C.IDCONTABILIZADO
        FROM   COBRARPAGARDOC C WITH (NOLOCK)
               JOIN CLIEPROV P WITH (NOLOCK)
                 ON ( C.IDCLIEPROV = P.IDCLIEPROV
                      AND C.IDEMPRESA = P.IDEMPRESA )
               JOIN MONEDAS M WITH (NOLOCK)
                 ON ( C.IDMONEDA = M.IDMONEDA )
               JOIN DOCUMENTOS D WITH (NOLOCK)
                 ON ( C.IDDOCUMENTO = D.IDDOCUMENTO
                      AND C.IDEMPRESA = D.IDEMPRESA )
        WHERE  ( CONVERT(CHAR(6), C.FECHA, 112) BETWEEN @PERIODODESDE AND @PERIODOHASTA )
               AND C.ORIGEN = 'C'
               AND ISNULL(C.ES_APERTURA, 0) = 0
               AND C.IDEMPRESA = @IDEMPRESA
               AND ( ISNULL(D.CODIGO_SUNAT, '') <> ''
                     AND ( D.MOSTRAR_EN = 'V'
                            OR D.MOSTRAR_EN = 'A' ) )--AND C.IDCOBRARPAGARDOC = '_21716AUVI22700'
               AND LEN(RTRIM(ISNULL(C.IDOPERACION, ''))) <> 0 -- DACCH 14/10/2011
      OPEN A
      FETCH NEXT FROM A INTO @IDSUCURSAL, @IDREFERENCIA, @IDTIPOVENTA, @IDDOCUMENTO, @NUMDOCUMENTO, @FECHA, @VOUCHER, @RAZON_SOCIAL, @IDCLIENTE, @RUC, @DSC_DOCUMENTO, @TIPO_MONEDA, @MONEDA, @TCAMBIO, @TCMONEDA, @VENTANA, @REGAGRICOLA, @EXPORTACION, @IDESTADO, @FACTOR, @VVENTA, @DESCUENTO, @INAFECTO, @TOTAL, @DOC_SUNAT, @PERIODO, @TIPOPERSONA, @VENCIMIENTO, @IDCONTABILIZADO
      WHILE @@FETCH_STATUS = 0
        BEGIN
            IF @AMBITO = ''
                OR EXISTS (SELECT IDDOCUMENTO
                           FROM   DAMBITOXCOBRAR WITH (NOLOCK)
                           WHERE  IDDOCUMENTO = @IDDOCUMENTO
                                  AND IDAMBITOXC = @AMBITO
                                  AND IDEMPRESA = @IDEMPRESA)
              BEGIN
                  SELECT @IDCUENTA = CASE @TIPOMONEDA
                                       WHEN 'N' THEN D.IDCUENTAMOF
                                       ELSE D.IDCUENTAMEX
                                     END,
                         @DESCRIPCION = P.DESCRIPCION
                  FROM   DOCTIPOVENTA D WITH (NOLOCK)
                         JOIN PLANCTAS P WITH (NOLOCK)
                           ON P.IDCUENTA = D.IDCUENTAMOF
                              AND P.IDEMPRESA = D.IDEMPRESA
                  WHERE  D.IDDOCUMENTO = @IDDOCUMENTO
                         AND D.IDTIPOVENTA = @IDTIPOVENTA
                         AND D.IDEMPRESA = @IDEMPRESA
                  IF RTRIM(@IDESTADO) <> 'AN'
                    BEGIN
                        SELECT @VVENTA = @VVENTA * @FACTOR,
                               @DESCUENTO = @DESCUENTO * @FACTOR,
                               @INAFECTO = @INAFECTO * @FACTOR,
                               @TOTAL = @TOTAL * @FACTOR
                        SELECT @ANTICIPO = ISNULL(SUM(ISNULL(IMPORTE, 0)), 0)
                        FROM   ACOBRARPAGARDOC WITH (NOLOCK)
                        WHERE  IDCOBRARPAGARDOC = @IDREFERENCIA
                               AND IDEMPRESA = @IDEMPRESA
                         IF @VVENTA <> 0
                          SET @VVENTA = @VVENTA - ( @ANTICIPO * @FACTOR )
                        ELSE
                          SET @INAFECTO = @INAFECTO - ( @ANTICIPO * @FACTOR )
                        IF @TIPOMONEDA = 'N'
                          BEGIN
                              SELECT @INAFECTO = CASE @TIPO_MONEDA
                                                   WHEN 'E' THEN @INAFECTO * @TCAMBIO
                                                   WHEN 'O' THEN ( @INAFECTO * @TCMONEDA ) * @TCAMBIO
                                                   ELSE @INAFECTO
                                                 END,
                                     @VVENTA = CASE @TIPO_MONEDA
                                                 WHEN 'E' THEN @VVENTA * @TCAMBIO
                                                 WHEN 'O' THEN ( @VVENTA * @TCMONEDA ) * @TCAMBIO
                                                 ELSE @VVENTA
                                               END,
                                     @DESCUENTO = CASE @TIPO_MONEDA
                                                    WHEN 'E' THEN @DESCUENTO * @TCAMBIO
                                                    WHEN 'O' THEN ( @DESCUENTO * @TCMONEDA ) * @TCAMBIO
                                                    ELSE @DESCUENTO
                                                  END,
                                     @TOTALUS = CASE @TIPO_MONEDA
                                                  WHEN 'E' THEN @TOTAL
                                                  WHEN 'O' THEN @TOTAL * @TCMONEDA
                                                  ELSE @TOTAL / @TCAMBIO
                                                END,
                                     @TOTAL = CASE @TIPO_MONEDA
                                                WHEN 'E' THEN @TOTAL * @TCAMBIO
                                                WHEN 'O' THEN ( @TOTAL * @TCMONEDA ) * @TCAMBIO
                                                ELSE @TOTAL
                                              END
                          END
                        IF @TIPOMONEDA = 'E'
                          BEGIN
                              SELECT @INAFECTO = CASE @TIPO_MONEDA
                                                   WHEN 'N' THEN @INAFECTO / @TCAMBIO
                                                   WHEN 'O' THEN ( @INAFECTO * @TCMONEDA )
                                                   ELSE @INAFECTO
                                                 END,
                                     @VVENTA = CASE @TIPO_MONEDA
                                                 WHEN 'N' THEN @VVENTA / @TCAMBIO
                                                 WHEN 'O' THEN ( @VVENTA * @TCMONEDA )
                                                 ELSE @VVENTA
                                               END,
                                     @DESCUENTO = CASE @TIPO_MONEDA
                                                    WHEN 'N' THEN @DESCUENTO / @TCAMBIO
                                                    WHEN 'O' THEN ( @DESCUENTO * @TCMONEDA )
                                                    ELSE @DESCUENTO
                                                  END,
                                     @TOTALUS = CASE @TIPO_MONEDA
                                                  WHEN 'N' THEN @TOTAL / @TCAMBIO
                                                  WHEN 'O' THEN @TOTAL * @TCMONEDA
                                                  ELSE @TOTAL
                                                END,
                                     @TOTAL = CASE @TIPO_MONEDA
                                                WHEN 'N' THEN @TOTAL / @TCAMBIO
                                                WHEN 'O' THEN ( @TOTAL * @TCMONEDA )
                                                ELSE @TOTAL
                                              END
                          END
                        SELECT @OTROS = 0,
                               @ISC = 0,
                               @IMPTO_AFEC = 0,
                               @IMPTO_EXON = 0
                        DECLARE B CURSOR FOR
                          SELECT ISNULL(C.IDIMPUESTO, ''),
                                 ISNULL(SUM(C.IMPUESTO), 0) * @FACTOR
                          FROM   ICOBRARPAGARDOC C WITH (NOLOCK)
                          WHERE  C.IDCOBRARPAGARDOC = @IDREFERENCIA
                                 AND C.IDEMPRESA = @IDEMPRESA
                          GROUP  BY C.IDIMPUESTO
                        OPEN B
                        FETCH NEXT FROM B INTO @IDIMPUESTO, @IMPUESTO
                        WHILE @@FETCH_STATUS = 0
                          BEGIN
                              IF @TIPOMONEDA = 'N'
                                SELECT @IMPUESTO = CASE @TIPO_MONEDA
                                                     WHEN 'E' THEN @IMPUESTO * @TCAMBIO
                                                     WHEN 'O' THEN ( @IMPUESTO * @TCMONEDA ) * @TCAMBIO
                                                     ELSE @IMPUESTO
                                                   END
                              ELSE
                                SELECT @IMPUESTO = CASE @TIPO_MONEDA
                                                     WHEN 'N' THEN @IMPUESTO / @TCAMBIO
                                                     WHEN 'O' THEN ( @IMPUESTO * @TCMONEDA )
                                                     ELSE @IMPUESTO
                                                   END
                              SELECT @PARAMETRO = VALOR
                              FROM   PEMPRESA WITH (NOLOCK)
                              WHERE  PARAMETRO = 'IMP_IGV'
                                     AND IDEMPRESA = @IDEMPRESA
                              IF @PARAMETRO = @IDIMPUESTO
                                BEGIN
                                    IF @REGAGRICOLA = 1
                                      SET @IMPTO_EXON = @IMPTO_EXON + @IMPUESTO
                                    ELSE
                                      SET @IMPTO_AFEC = @IMPTO_AFEC + @IMPUESTO
                                END
                              ELSE
                                BEGIN
                                    SELECT @PARAMETRO = VALOR
                                    FROM   PEMPRESA WITH (NOLOCK)
                                    WHERE  PARAMETRO = 'IMP_ISC'
                                           AND IDEMPRESA = @IDEMPRESA
                                    IF @PARAMETRO = @IDIMPUESTO
                                      SET @ISC = @ISC + @IMPUESTO
                                    ELSE
                                      SET @OTROS = @OTROS + @IMPUESTO
                                END
                              FETCH NEXT FROM B INTO @IDIMPUESTO, @IMPUESTO
                          END
                        CLOSE B
                        DEALLOCATE B
                        SET @DIFERENCIA = @TOTAL - ( @VVENTA + @INAFECTO + @IMPTO_AFEC + @IMPTO_EXON + @OTROS + @ISC )
                        IF @VVENTA <> 0 --@DESCUENTO
                          BEGIN
                              SET @VVENTA = @VVENTA + @DIFERENCIA + @DESCUENTO
                              IF @REGAGRICOLA = 0
                                 AND @EXPORTACION = 0
                                SELECT @BASEIMP_AFEC = @VVENTA - @DESCUENTO,
                                       @BASEIMP_EXON = 0,
                                       @BASEIMP_EXPO = 0
                              IF @REGAGRICOLA = 1
                                SELECT @BASEIMP_AFEC = 0,
                                       @BASEIMP_EXON = @VVENTA - @DESCUENTO,
                                       @BASEIMP_EXPO = 0
                          END
                        ELSE
                          SELECT @BASEIMP_AFEC = 0,
                                 @BASEIMP_EXON = 0,
                                 @BASEIMP_EXPO = 0,
                                 @INAFECTO = @INAFECTO + @DIFERENCIA --+ @DESCUENTO
                        IF @EXPORTACION = 1
                          BEGIN
                              IF @TIPOMONEDA = 'N'
                                SELECT @GASTOS = SUM(ISNULL(TOTALMOF, 0))
                                FROM   GCOBRARPAGARDOC WITH (NOLOCK)
                                WHERE  IDCOBRARPAGARDOC = @IDREFERENCIA
                                       AND IDEMPRESA = @IDEMPRESA
                              ELSE
                                SELECT @GASTOS = SUM(ISNULL(TOTALMEX, 0))
                                FROM   GCOBRARPAGARDOC WITH (NOLOCK)
                                WHERE  IDCOBRARPAGARDOC = @IDREFERENCIA
                                       AND IDEMPRESA = @IDEMPRESA
                              SET @OTROS = @OTROS + ISNULL(@GASTOS, 0)
                              SET @VVENTA = @VVENTA + @INAFECTO - @OTROS
                              SET @BASEIMP_AFEC = 0
                              SET @BASEIMP_EXON = 0
                              SET @BASEIMP_EXPO = @VVENTA - @DESCUENTO
                              SET @INAFECTO = 0.00
                          END
                        INSERT INTO #REGISTROVENTAS
                                    (IDEMPRESA,
                                     IDSUCURSAL,
                                     IDTIPOVENTA,
                                     IDREFERENCIA,
                                     VENTANA,
                                     FECHA,
                                     IDDOCUMENTO,
                                     NUMDOCUMENTO,
                                     IDCLIEPROV,
                                     RUC,
                                     RAZON_SOCIAL,
                                     BASEIMP_AFEC,
                                     BASEIMP_EXPO,
                                     BASEIMP_EXON,
                                     INAFECTO,
                                     ISC,
                                     IMPTO_AFEC,
                                     IMPTO_EXON,
                                     OTROS,
                                     TOTAL,
                                     MONEDA,
                                     TCAMBIO,
                                     IGV,
                                     TOTALUS,
                                     DSC_DOCUMENTO,
                                     COMPROBANTE,
                                     DOC_SUNAT,
                                     PERIODO,
                                     TIPOPERSONA,
                                     VENCIMIENTO,
                                     IDCONTABILIZADO,
                                     IDCOBRARPAGARDOC)
                        VALUES      ( @IDEMPRESA,
                                      @IDSUCURSAL,
                                      @IDTIPOVENTA,
                                      @IDREFERENCIA,
                                      @VENTANA,
                                      @FECHA,
                                      @IDDOCUMENTO,
                                      @NUMDOCUMENTO,
                                      @IDCLIENTE,
                                      @RUC,
                                      @RAZON_SOCIAL,
                                      @BASEIMP_AFEC,
                                      @BASEIMP_EXPO,
                                      @BASEIMP_EXON,
                                      @INAFECTO,
                                      @ISC,
                                      @IMPTO_AFEC,
                                      @IMPTO_EXON,
                                      @OTROS,
                                      @TOTAL,
                                      @MONEDA,
                                      @TCAMBIO,
                                      @IGV,
                                      @TOTALUS,
                                      @DSC_DOCUMENTO,
                                      @VOUCHER,
                                      @DOC_SUNAT,
                                      @PERIODO,
                                      @TIPOPERSONA,
                                      @VENCIMIENTO,
                                      @IDCONTABILIZADO,
                                      @IDREFERENCIA )
                    END
                  ELSE
                    BEGIN
                        INSERT INTO #REGISTROVENTAS
                                    (IDEMPRESA,
                                     IDSUCURSAL,
                                     IDTIPOVENTA,
                                     IDREFERENCIA,
                                     VENTANA,
                                     FECHA,
                                     IDDOCUMENTO,
                                     NUMDOCUMENTO,
                                     IDCLIEPROV,
                                     RUC,
                                     RAZON_SOCIAL,
                                     BASEIMP_AFEC,
                                     BASEIMP_EXPO,
                                     BASEIMP_EXON,
                                     INAFECTO,
                                     ISC,
                                     IMPTO_AFEC,
                                     IMPTO_EXON,
                                     OTROS,
                                     TOTAL,
                                     MONEDA,
                                     TCAMBIO,
                                     IGV,
                                     TOTALUS,
                                     DSC_DOCUMENTO,
                                     COMPROBANTE,
                                     DOC_SUNAT,
                                     PERIODO,
                                     TIPOPERSONA,
                                     VENCIMIENTO,
                                     IDCONTABILIZADO,
                                     IDCOBRARPAGARDOC)
                        VALUES      ( @IDEMPRESA,
                                      @IDSUCURSAL,
                                      @IDTIPOVENTA,
                                      @IDREFERENCIA,
                                      @VENTANA,
                                      @FECHA,
                                      @IDDOCUMENTO,
                                      @NUMDOCUMENTO,
                                      @IDCLIENTE,
                                      @RUC,
                                      '*** A N U L A D O ***',
                                      0.00,
                                      0.00,
                                      0.00,
                                      0.00,
                                      0.00,
                                      0.00,
                                      0.00,
                                      0.00,
                                      0.00,
                                      @MONEDA,
                                      0.00,
                                      0.00,
                                      0.00,
                                      @DSC_DOCUMENTO,
                                      @VOUCHER,
                                      @DOC_SUNAT,
                                      @PERIODO,
                                      @TIPOPERSONA,
                                      @VENCIMIENTO,
                                      @IDCONTABILIZADO,
                                      @IDREFERENCIA )
                    END
              END
            FETCH NEXT FROM A INTO @IDSUCURSAL, @IDREFERENCIA, @IDTIPOVENTA, @IDDOCUMENTO, @NUMDOCUMENTO, @FECHA, @VOUCHER, @RAZON_SOCIAL, @IDCLIENTE, @RUC, @DSC_DOCUMENTO, @TIPO_MONEDA, @MONEDA, @TCAMBIO, @TCMONEDA, @VENTANA, @REGAGRICOLA, @EXPORTACION, @IDESTADO, @FACTOR, @VVENTA, @DESCUENTO, @INAFECTO, @TOTAL, @DOC_SUNAT, @PERIODO, @TIPOPERSONA, @VENCIMIENTO, @IDCONTABILIZADO
        END
      CLOSE A
      DEALLOCATE A
      --DOCUMENTO DE REFERENCIA
      DECLARE RV CURSOR FOR
        SELECT IDREFERENCIA,
               DOC_SUNAT
        FROM   #REGISTROVENTAS
        WHERE  DOC_SUNAT IN ( '07', '08' )
      OPEN RV
      FETCH NEXT FROM RV INTO @IDREFERENCIA, @DOC_SUNAT
      WHILE @@FETCH_STATUS = 0
        BEGIN
            SELECT @DOC_REFE = '',
                   @OTRAREFE = '',
                   @FECHAREFER = '',
                   @TIPOREFER = '',
                   @SERIEREFER = '',
                   @NUMEROREFER = ''
            SELECT @DOC_REFE = ISNULL(DC.CODIGO_SUNAT, '') + ' ' + DCP.SERIE + '-' + DCP.NUMERO,
                   @OTRAREFE = ISNULL(DCP.IDREFERENCIA, ''),
                   @FECHAREFER = DCP.FECHA,
                   @TIPOREFER = DC.CODIGO_SUNAT,
                   @SERIEREFER = DCP.SERIE,
                   @NUMEROREFER = DCP.NUMERO
            FROM   DOCREFERENCIA_CP DCP WITH (NOLOCK)
                   LEFT JOIN DOCUMENTOS DC WITH (NOLOCK)
                     ON DCP.IDDOCUMENTO = DC.IDDOCUMENTO
                        AND DCP.IDEMPRESA = DC.IDEMPRESA
            WHERE  IDORIGEN = @IDREFERENCIA
                   AND DCP.TABLA = 'COBRARPAGARDOC'
                   AND DCP.IDEMPRESA = @IDEMPRESA
            IF LEN(RTRIM(@OTRAREFE)) > 0
              BEGIN
                  UPDATE #REGISTROVENTAS
                  SET    DOC_REFE = @DOC_REFE,
                         FECHAREFER = @FECHAREFER,
                         TIPOREFER = @TIPOREFER,
                         SERIEREFER = @SERIEREFER,
                         NUMEROREFER = @NUMEROREFER
                  WHERE  IDREFERENCIA = @IDREFERENCIA
                  --TIPO DE CAMBIO DE REFERENCIA
                  SET @TCAMBIO = 0
                  IF @DOC_SUNAT = '07'
                    SELECT @TCAMBIO = ISNULL(TCAMBIO, 0)
                    FROM   COBRARPAGARDOC WITH (NOLOCK)
                    WHERE  IDEMPRESA = @IDEMPRESA
                           AND IDCOBRARPAGARDOC = @OTRAREFE
                  IF @TCAMBIO > 0
                    BEGIN
                        UPDATE #REGISTROVENTAS
                        SET    TCAMBIO = @TCAMBIO
                        WHERE  IDREFERENCIA = @IDREFERENCIA
                    END
              END
            FETCH NEXT FROM RV INTO @IDREFERENCIA, @DOC_SUNAT
        END
      CLOSE RV
      DEALLOCATE RV
      --BEGIN
      --SELECT * FROM #REGISTROVENTAS    ORDER BY IDDOCUMENTO, NUMDOCUMENTO
      --END
      DECLARE VM CURSOR FOR
        SELECT C.IDCOBRARPAGARDOC,
               C1.IDDOCUMENTO + ' ' + C1.SERIE + '-' + C1.NUMERO AS DOC_DEB_CRED
        FROM   #REGISTROVENTAS C
               INNER JOIN DOCREFERENCIA_CP CP WITH (NOLOCK)
                 ON CP.IDEMPRESA = C.IDEMPRESA
                    AND CP.IDREFERENCIA = C.IDCOBRARPAGARDOC
               INNER JOIN COBRARPAGARDOC C1 WITH (NOLOCK)
                 ON C1.IDEMPRESA = C.IDEMPRESA
                    AND C1.IDCOBRARPAGARDOC = CP.IDORIGEN
      OPEN VM
      FETCH NEXT FROM VM INTO @IDREFERENCIA, @DOC_DEB_CRED
      WHILE @@FETCH_STATUS = 0
        BEGIN
            IF EXISTS (SELECT DOC_REFE
                       FROM   #REGISTROVENTAS
                       WHERE  IDEMPRESA = @IDEMPRESA
                              AND IDCOBRARPAGARDOC = @IDREFERENCIA)
              BEGIN
                  UPDATE #REGISTROVENTAS
                  SET    DOC_REFE = @DOC_DEB_CRED
                  WHERE  IDEMPRESA = @IDEMPRESA
                         AND IDCOBRARPAGARDOC = @IDREFERENCIA
              END
            ELSE
              BEGIN
                  UPDATE #REGISTROVENTAS
                  SET    DOC_REFE = DOC_REFE + ',' + @DOC_DEB_CRED
                  WHERE  IDEMPRESA = @IDEMPRESA
                         AND IDCOBRARPAGARDOC = @IDREFERENCIA
              END
            FETCH NEXT FROM VM INTO @IDREFERENCIA, @DOC_DEB_CRED
        END
      CLOSE VM
      DEALLOCATE VM
      UPDATE #REGISTROVENTAS
      SET    TD = TIPOPERSONA
      --FIN DOCUMENTO DE REFERENCIA
      IF @PORCUENTA = 0
        --SELECT * FROM #REGISTROVENTAS ORDER BY IDDOCUMENTO, NUMDOCUMENTO
        SELECT R.*,
               ISNULL(C.IDSUBDIARIO, '') + ' ' + RIGHT(ISNULL(C.VOUCHER, ''), 5) AS NUMVOUCHER
        FROM   #REGISTROVENTAS R
               LEFT JOIN COBRARPAGARDOC C WITH (NOLOCK)
                 ON R.IDREFERENCIA = C.IDCOBRARPAGARDOC
                    AND C.IDEMPRESA = @IDEMPRESA
        ORDER  BY R.IDDOCUMENTO,
                  R.NUMDOCUMENTO
      ELSE
        BEGIN
            --SELECT * FROM #REGISTROVENTAS    ORDER BY IDDOCUMENTO, NUMDOCUMENTO
        /* 
      IF @TIPOMONEDA = 'N'
                  SELECT DISTINCT R.*, CASE M.TIPO_MONEDA WHEN 'N' THEN D.IDCUENTAMOF ELSE D.IDCUENTAMEX END AS IDCUENTA,
                  CASE M.TIPO_MONEDA WHEN 'N' THEN P.DESCRIPCION ELSE P1.DESCRIPCION END AS DSC_CUENTA FROM #REGISTROVENTAS R
                  LEFT JOIN DOCTIPOVENTA D ON D.IDDOCUMENTO = R.IDDOCUMENTO AND D.IDTIPOVENTA = R.IDTIPOVENTA AND D.IDEMPRESA = @IDEMPRESA
                  LEFT JOIN PLANCTAS P ON D.IDCUENTAMOF = P.IDCUENTA AND D.IDEMPRESA = P.IDEMPRESA
                  LEFT JOIN PLANCTAS P1 ON D.IDCUENTAMEX = P1.IDCUENTA AND D.IDEMPRESA = P1.IDEMPRESA
                  JOIN MONEDAS M ON M.NOMBRE_CORTO = R.MONEDA
            ELSE
                  SELECT DISTINCT R.*, P.IDCUENTA, P.DESCRIPCION AS DSC_CUENTA FROM #REGISTROVENTAS R
                  LEFT JOIN DOCTIPOVENTA D ON D.IDDOCUMENTO = R.IDDOCUMENTO AND D.IDTIPOVENTA = R.IDTIPOVENTA AND D.IDEMPRESA = @IDEMPRESA
                  LEFT JOIN PLANCTAS P ON D.IDCUENTAMEX = P.IDCUENTA AND D.IDEMPRESA = P.IDEMPRESA
      */
            /* JEFR -- CAMBIO PARA QUE TRAIGA DEL ASIENTO CONTABLE - 01-09-2008*/
            IF @TIPOMONEDA = 'N'
              SELECT DISTINCT R.*,
                              CASE M.TIPO_MONEDA
                                WHEN 'N' THEN D.IDCUENTA
                                ELSE DD.IDCUENTAMEX
                              END AS IDCUENTA,
                              CASE M.TIPO_MONEDA
                                WHEN 'N' THEN P.DESCRIPCION
                                ELSE P1.DESCRIPCION
                             END AS DSC_CUENTA,
                              C.IDSUBDIARIO + ' ' + RIGHT(C.VOUCHER, 5) AS NUMVOUCHER
              FROM   #REGISTROVENTAS R
                     LEFT JOIN DOCTIPOVENTA DD WITH (NOLOCK)
                       ON R.IDDOCUMENTO = DD.IDDOCUMENTO
                          AND R.IDTIPOVENTA = DD.IDTIPOVENTA --AND D.IDEMPRESA = @IDEMPRESA
                     LEFT JOIN DETCONTA D WITH (NOLOCK)
                       ON R.IDCONTABILIZADO = D.IDCABCONTA
                          AND R.IDEMPRESA = D.IDEMPRESA
                          AND LEFT(D.IDCUENTA, 1) = '7'
                     LEFT JOIN CABCONTA C WITH (NOLOCK)
                       ON D.IDCABCONTA = C.IDCABCONTA
                          AND D.IDEMPRESA = C.IDEMPRESA
                     LEFT JOIN PLANCTAS P WITH (NOLOCK)
                       ON D.IDCUENTA = P.IDCUENTA
                          AND D.IDEMPRESA = P.IDEMPRESA
                     LEFT JOIN PLANCTAS P1 WITH (NOLOCK)
                       ON DD.IDCUENTAMEX = P1.IDCUENTA
                          AND D.IDEMPRESA = P1.IDEMPRESA
                     JOIN MONEDAS M WITH (NOLOCK)
                       ON M.NOMBRE_CORTO = R.MONEDA
              WHERE  LEFT(D.IDCUENTA, 1) = '7'
                     AND D.IDEMPRESA = @IDEMPRESA
            ELSE
              SELECT DISTINCT R.*,
                              D.IDCUENTA,
                              P.DESCRIPCION AS DSC_CUENTA,
                              C.IDSUBDIARIO + ' ' + RIGHT(C.VOUCHER, 5) AS NUMVOUCHER
              FROM   #REGISTROVENTAS R
                     LEFT JOIN DETCONTA D WITH (NOLOCK)
                       ON R.IDCONTABILIZADO = D.IDCABCONTA
                          AND R.IDEMPRESA = D.IDEMPRESA
                          AND LEFT(D.IDCUENTA, 1) = '7'
                     LEFT JOIN CABCONTA C WITH (NOLOCK)
                       ON D.IDCABCONTA = C.IDCABCONTA
                          AND D.IDEMPRESA = C.IDEMPRESA
                     LEFT JOIN PLANCTAS P WITH (NOLOCK)
                       ON D.IDCUENTA = P.IDCUENTA
                          AND D.IDEMPRESA = P.IDEMPRESA
                     JOIN MONEDAS M WITH (NOLOCK)
                       ON M.NOMBRE_CORTO = R.MONEDA
              WHERE  LEFT(D.IDCUENTA, 1) = '7'
                     AND D.IDEMPRESA = @IDEMPRESA
        END
  END


GO


